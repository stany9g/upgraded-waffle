using System.Collections.Generic;

namespace Market.BusinessLogic.Dto
{
    // Data transfer object
    public class CustomerDto
    {
        public string Name { get; set; }

        public StoreCardDto StoreCard { get; set; }

        public IEnumerable<OrderDto> Orders { get; set; }
    }
}