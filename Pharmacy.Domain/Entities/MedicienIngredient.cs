﻿using System;
using System.Collections.Generic;

namespace Pharmacy.Domain.Entities
{
    public partial class MedicienIngredient
    {
        public int Id { get; set; }
        public int Medicine { get; set; }
        public int Ingredient { get; set; }
        public decimal Ratio { get; set; }

        public virtual Ingredient IngredientNavigation { get; set; } = null!;
        public virtual Medicine MedicineNavigation { get; set; } = null!;
    }
}
