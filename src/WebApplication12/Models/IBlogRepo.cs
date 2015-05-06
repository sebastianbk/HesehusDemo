using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication12.Models
{
    public interface IBlogRepo
    {
        BlogPost GetPost();
    }
}
