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
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public Boolean Enabled { get; set; }

		[Required]
		[DataType(DataType.DateTime)]
		[Display(AutoGenerateField = false, GroupName = "Candidate", Description = "Created date", Name = "Created", Prompt = "Created date", ShortName = "Created")]
		public DateTime CreatedDate { get; set; }

		[Required]
		[Display(GroupName = "Candidate", Description = "Last modified date", Name = "Modified", Prompt = "Last modified date", ShortName = "Modified")]
		[DataType(DataType.DateTime)]
		public DateTime LastModifiedDate { get; set; }

		#endregion

		[Display(GroupName = "Candidate", Description = "Candidate Name", Name = "Candidate", Prompt = "Candidate name", ShortName = "Candidate")]
		public String CandidateId { get; set; }

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
		[DataType(DataType.Text)]
		[Display(GroupName = "Referee", Description = "Referee Name", Name = "Referee", Prompt = "Referee name", ShortName = "Referee")]
		public string RefereeName { get; set; }

		[Required]
		[DataType(DataType.Text)]
		[Display(GroupName = "Referee", Description = "Referee Employer", Name = "Referee Employer", Prompt = "Referee Employer", ShortName = "Referee Employer")]
		public string RefereeEmployer { get; set; }

		[Required]
		[DataType(DataType.Text)]
		[Display(GroupName = "Referee", Description = "Referee Title", Name = "Referee Title", Prompt = "Referee Title", ShortName = "Referee Title")]
		public string RefereeTitle { get; set; }

		[Required]
		[DataType(DataType.EmailAddress)]
		[Display(GroupName = "Referee", Description = "Referee Email", Name = "Referee Email", Prompt = "Referee Email", ShortName = "Referee Email")]
		public string RefereeEmail { get; set; }

		[Required]
		[DataType(DataType.PhoneNumber)]
		[Display(GroupName = "Referee", Description = "Referee Phone", Name = "Referee Phone", Prompt = "Referee Phone", ShortName = "Phone")]
		public string RefereeTelephone { get; set; }
	}
}