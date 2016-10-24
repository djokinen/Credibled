using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Credibled.Models
{
	public class ReferenceRequestQuestionAnswer : IBaseModelProperties
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

		// public Guid ReferenceRequestId { get; set; }

		// public Guid QuestionId { get; set; }

		public ReferenceRequest ReferenceRequest { get; set; }

		public Question Question { get; set; }

		public string Answer { get; set; }
	}
}