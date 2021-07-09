using Microsoft.EntityFrameworkCore;
using prueba.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace prueba.Models.CustomValidations
{
    public class CheckDescriptionArea : ValidationAttribute
    {
        private ServiceSettings con = new ServiceSettings();
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var connectionStr = con.GetConnectionString();
            var contextOptions = new DbContextOptionsBuilder<AppDbContext>().UseMySql(connectionStr, ServerVersion.AutoDetect(connectionStr)).Options;
            using (var db = new AppDbContext(contextOptions))
            {
                string Description = (string)value;
                if (db.Areas.Where(e => e.Descripcion == Description).Count() > 0)
                {
                    return new ValidationResult("Este nombre para el area ya existe");
                }
            }

            return ValidationResult.Success;
        }
    }
}
