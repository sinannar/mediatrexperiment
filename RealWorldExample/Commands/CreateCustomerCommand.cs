using Newtonsoft.Json;
using RealWorldExample.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RealWorldExample.Commands
{
    public class CreateCustomerCommand : CommandBase<CustomerDto>
    {
        public CreateCustomerCommand()
        {
        }

        [JsonProperty("name")]
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        [JsonProperty("email")]
        [Required]
        [MaxLength(255)]
        [EmailAddress]
        public string Email { get; set; }
        [JsonProperty("address")]
        [Required]
        [MaxLength(255)]
        public string Address { get; set; }
        [JsonProperty("age")]
        [Required]
        public int Age { get; set; }
        [JsonProperty("phone_number")]
        [Required]
        [Phone]
        public string PhoneNumber { get; set; }
    }
}
