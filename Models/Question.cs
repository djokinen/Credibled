using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Credibled.Models
{
    public class Question : IBaseModelProperties
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
		public string QuestionText { get; set; }

		[Required]
		[Description("The data type defines the display iof this question, The type could be boolean, text, etc...")]
		public DataType QuestionDataType { get; set; }
	}
}