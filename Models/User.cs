﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ConsoleApp2.Models;

public partial class User
{
    public int UserId { get; set; }

    public string UserName { get; set; }

    public string Email { get; set; }

    public DateTime? DateJoined { get; set; }

    public int? Reputation { get; set; }

    public virtual ICollection<Answer> Answers { get; set; } = new List<Answer>();

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();

    public virtual ICollection<UserBadge> UserBadges { get; set; } = new List<UserBadge>();

    public virtual ICollection<Vote> Votes { get; set; } = new List<Vote>();
}