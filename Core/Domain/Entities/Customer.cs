﻿using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class Customer: BaseEntity
	{
		public ICollection<Order> Orders { get; set; }

		public string Name { get; set; }


	}
}
