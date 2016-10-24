using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.ComponentModel;

namespace Credibled.Models
{
	// Add profile data for application users by adding properties to the ApplicationUser class
	public class ApplicationUser : IdentityUser
	{
		[DisplayName("I am a Candidate")]
		public Boolean IsCandidate { get; set; }

		[DisplayName("I agree to the terms")]
		public Boolean AgreeToTerms { get; set; }

		public DateTime AgreeToTermsDateTime { get; set; }
	}
}
