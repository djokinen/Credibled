using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Credibled.Models
{
	public class Referee : IBaseModelProperties
	{
		#region IBaseModel Properties

		[Required]
		public Guid ID { get; set; }

		[DefaultValue(true)]
		public Boolean Enabled { get; set; }

		[Required]
		[DataType(DataType.DateTime)]
		public DateTime CreatedDate { get; set; }

		[Required]
		[DataType(DataType.DateTime)]
		public DateTime LastModifiedDate { get; set; }

		#endregion

		[Required]
		[DataType(DataType.Text)]
		public string RefereeName { get; set; }

		[Required]
		[DataType(DataType.Text)]
		public string RefereeEmployer { get; set; }

		[Required]
		[DataType(DataType.Text)]
		public string RefereeTitle { get; set; }

		[Required]
		[DataType(DataType.EmailAddress)]
		public string RefereeEmail { get; set; }

		[Required]
		[DataType(DataType.PhoneNumber)]
		public string RefereeTelephone { get; set; }

	}
}