using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TinyCrmConsole
{
    public class OrderService : IOrderService
    {
        private TinyCrmDbContext context_;
        private ICustomerService customerService;
        private IProductService productService;
        public OrderService(TinyCrmDbContext context, ICustomerService custService, IProductService prodService)
        {
            context_ = context;
            customerService = custService;
            productService = prodService;
        }

        public Order CreateOrder(OrderCreateOptions options)
        {
            if (options == null)
            {
                return null;
            }

            var customer = customerService.SearchCustomer(new CustomerSearchOptions()
            {
                CustomerId = options.CustomerId
            }).SingleOrDefault();

            if (customer == null)
            {
                return null;
            }

            var order = new Order()
            {
                DeliveryAddress = options.DeliveryAddress
            };

            foreach (var p in options.ProductIds)
            {
                var product = productService.GetProductById(p);
                            
                if (product != null)
                {
                    var orderProduct = new OrderProduct()
                    {
                        Product = product
                    };

                    order.OrderProducts.Add(orderProduct);
                    order.TotalAmount += product.Price;
                }
                else
                {
                    return null;
                }
            }

            customer.OrderList.Add(order);

            context_.SaveChanges();
            return order;
        }

        public IQueryable<Order> SearchOrder(OrderSearchOptions options)
        {
            if (options == null)
            {
                return null;
            }

            var query = context_
                         .Set<Order>()
                         .AsQueryable();

            if (options.OrderId != null)
            {
                query = query.Where(o => o.OrderId == options.OrderId);
            }
            if (options.PriceFrom != null)
            {
                query = query.Where(o => o.TotalAmount >= options.PriceFrom);
            }
            if (options.PriceTo != null)
            {
                query = query.Where(o => o.TotalAmount <= options.PriceTo);
            }
            if (options.DeliveryAddress != null)
            {
                query = query.Where(o => o.DeliveryAddress == options.DeliveryAddress);
            }

            query = query.Include(o => o.OrderProducts);

            return query;
        }

        public Order GetOrderById(int? ordId)
        {
            if( ordId == null)
            {
                return null;
            }

            var order = context_
                .Set<Order>()
                .Where(ord => ord.OrderId == ordId)
                .Include(ord => ord.OrderProducts)
                .SingleOrDefault();

            if (order != null)
            {
                return order;
            }
            return null;
        }

        public Order UpdateOrder(OrderUpdateOptions options, int? ordId)
        {
            if (options == null || ordId == null)
            {
                return null;
            }

            var order = GetOrderById(ordId);

            order.DeliveryAddress = options.DeliveryAddress;

            context_.SaveChanges();

            return order;
        }
    }
}
