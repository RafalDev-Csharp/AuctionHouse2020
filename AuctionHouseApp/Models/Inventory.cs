using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionHouseApp.Models
{
    public class Inventory
    {
        public int Id { get; set; }

        [Range(1, 999, ErrorMessage = "Price should be greater than 1 and smaller then 1000")]
        public int Count { get; set; }
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Game Item")]
        public int GameItemId { get; set; }
        [ForeignKey("GameItemId")]
        public virtual GameItem GameItemVP { get; set; }


        public string GameUserId { get; set; }

        [NotMapped]
        [ForeignKey("GameUserId")]
        public virtual GameUser GameUserVP { get; set; }
    }
}
