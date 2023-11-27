using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesssLayer.Abstract
{
	public interface ICommentService
	{
		void CommentAdd(Comment comment);
		

		List<Comment> GetList(int id );
		
	}
}
