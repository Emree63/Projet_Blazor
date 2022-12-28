﻿namespace DemoGraphQL.Client.Models
{
    using System;
    using System.Collections.Generic;

    public class Owner
    {
        public ICollection<Account> Accounts { get; set; }
        public string Address { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}