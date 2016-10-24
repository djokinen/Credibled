using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Credibled.Models
{
	public class ReferenceRequest : IBaseModelProperties
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
		public String CandidateId { get; set; }

		[Required]
		public string RefereeId { get; set; }

		[Required]
		[DataType(DataType.Date)]
		public DateTime CandidateStartDate { get; set; }

		[Required]
		[DataType(DataType.Date)]
		public DateTime CandidateEndDate { get; set; }

		[Required]
		[DataType(DataType.MultilineText)]
		public String CandidateJobDuties { get; set; }
	}
}