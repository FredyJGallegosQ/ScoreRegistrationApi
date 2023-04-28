using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroNotasApi.Models
{
	public class Registration
	{
		public long id{get; set;}
		public long semesterId{get; set;}
		public long studentId{get; set;}
		public long psId{get; set;}
		[ForeignKey(nameof(semesterId))]
		public Semester? semester{get; set;}
		[ForeignKey(nameof(studentId))]
		public Student? student{get; set;}
		[ForeignKey(nameof(psId))]
		public PS? pS{get; set;}
		public IEnumerable<CourseRegistration>?  courseRegistrations{get; set;}
		// public IEnumerable<Student> students{get; set;}
		
		// public IEnumerable<Semester> semesters{get; set;}

	}
	public class RegistrationVM
	{
		public long id{get; set;}
		public long semesterId{get; set;}
		public long studentId{get; set;}
		public long psId{get; set;}
	}
}