using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.EntityFrameworkCore;
using OPLServer.Database;
using System.ComponentModel.DataAnnotations;

namespace OPLServer.Models.Entity
{
    public class FantasyPointRules
    {
        [Key]
        public int RuleID { get; set; }
        public required string RuleName { get; set; }
        public decimal Points { get; set; }
        public bool IsActive { get; set; }

    }
}
        