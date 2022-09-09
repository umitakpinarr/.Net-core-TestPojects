using Microsoft.AspNetCore.Mvc;
using mulk.Models;
using mulk.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mulk.ViewComponents
{
    public class ModalComponent2 : ViewComponent
    {
        private readonly DatabaseContext _databaseContext;

        public ModalComponent2(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public IViewComponentResult Invoke(int Id)
        {
            if(Id != 0)
            {
                rents DbRents = _databaseContext.rents.Where(x => x.Id == Id).FirstOrDefault();
                return View(DbRents);
            }
            else
            {
                return View();
            }
        }

    }
}
