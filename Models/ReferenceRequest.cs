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
		[Editable(false, AllowInitialValue = true)]
		[DataType(DataType.DateTime)]
		[Display(GroupName = "Candidate", Description = "Created date", Name = "Created", Prompt = "Created date", ShortName = "Created")]
		public DateTime CreatedDate { get; set; }

		[Required]
		[Editable(false, AllowInitialValue = true)]
		[Display(GroupName = "Candidate", Description = "Last modified date", Name = "Modified", Prompt = "Last modified date", ShortName = "Modified")]
		[DataType(DataType.DateTime)]
		public DateTime LastModifiedDate { get; set; }

		#endregion

		[Required]
		[Display(GroupName = "Candidate", Description = "Candidate Name", Name = "Candidate", Prompt = "Candidate name", ShortName = "Candidate")]
		public String CandidateId { get; set; }

		[Required]
		[DataType(DataType.Date)]
		[Display(GroupName = "Candidate", Description = "Candidate start date", Name = "Start", Prompt = "Start Date", ShortName = "Start")]
		public DateTime CandidateStartDate { get; set; }

		[Required]
		[DataType(DataType.Date)]
		[Display(GroupName = "Candidate", Description = "Candidate end date", Name = "End", Prompt = "End Date", ShortName = "End")]
		public DateTime CandidateEndDate { get; set; }

		[Required]
		[DataType(DataType.MultilineText)]
		[Display(GroupName = "Candidate", Description = "Candidate job duties", Name = "Duties", Prompt = "Candidate job duties", ShortName = "Duties")]
		public String CandidateJobDuties { get; set; }

		[Required]
		[Display(GroupName = "Referee", Description = "Referee Name", Name = "Referee", Prompt = "Referee name", ShortName = "Referee")]
		public string RefereeId { get; set; }
	}
}