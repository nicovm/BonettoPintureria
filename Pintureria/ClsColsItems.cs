using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pintureria
{
	public class clsColsItems : System.Collections.CollectionBase
	{
		public void add(ClsColItem addColItem )
		{
			List.Add(addColItem);
		}

		public ClsColItem items(int index){
			return (ClsColItem)List[index];
		}
	}
}
