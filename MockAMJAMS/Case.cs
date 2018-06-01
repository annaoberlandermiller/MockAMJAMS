using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockAMJAMS
{
	class Case
	{
		
		public string CaseID { get; set; }
		public string CaseType { get; set; }
		public string UCMJArts { get; set; }
		public Accused ACCName { get; set; }
		public LegalProf AttName { get; set; }
		public LegalProf ParaName { get; set; }
	}
}
