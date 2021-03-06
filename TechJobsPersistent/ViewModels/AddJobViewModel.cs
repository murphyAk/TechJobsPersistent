﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        [Required(ErrorMessage = "Job name is required.")]
        public string JobName { get; set; }

        public int EmployerId { get; set; }
        public List<SelectListItem> EmployerList { get; set; }

        public List<int> SkillId { get; set; }

        public List<Skill> Skills { get; set; }

        public AddJobViewModel()
        {
        }

        public AddJobViewModel(List<Employer> employers, List<Skill> skills)
        {
            EmployerList = new List<SelectListItem>();

            foreach (var employer in employers)
            {
                EmployerList.Add(
                    new SelectListItem
                    {
                        Value = employer.Id.ToString(),
                        Text = employer.Location
                    }
                );
            }
            Skills = skills;
        }
    }
}
