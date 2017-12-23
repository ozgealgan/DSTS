using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DSTS.localClass
{
	public class localOda
	{
		public int odaId { get; set; }
		public string odaAdi { get; set; }
		public int personelId { get; set; }
		public int fakulteId { get; set; }

		public virtual localFakulte localFakulte { get; set; }
		public virtual localpersonel localpersonel { get; set; }
		public virtual ICollection<localOdaDemirbas> localOdaDemirbas { get; set; }
	}
}