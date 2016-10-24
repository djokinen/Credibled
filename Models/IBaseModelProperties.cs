using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Credibled.Models
{
	interface IBaseModelProperties
	{
		[Required]
		Guid ID { get; set; }

		[DefaultValue(true)]
		Boolean Enabled { get; set; }

		[Required]
		[DataType(DataType.DateTime)]
		DateTime CreatedDate { get; }

		[Required]
		[DataType(DataType.DateTime)]
		DateTime LastModifiedDate { get; }
	}
}