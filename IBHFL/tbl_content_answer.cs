﻿// Decompiled with JetBrains decompiler
// Type: IBHFL.tbl_content_answer
// Assembly: IBHFL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7D5F13E8-66C2-4709-8C6B-C4D11A9CFC14
// Assembly location: D:\M2OST Desktop\console\bin\IBHFL.dll

using System;
using System.Collections.Generic;

namespace IBHFL
{
  public class tbl_content_answer
  {
    public tbl_content_answer()
    {
      this.tbl_content_answer_steps = (ICollection<IBHFL.tbl_content_answer_steps>) new HashSet<IBHFL.tbl_content_answer_steps>();
      this.tbl_content_metadata = (ICollection<IBHFL.tbl_content_metadata>) new HashSet<IBHFL.tbl_content_metadata>();
      this.tbl_content_type_link = (ICollection<IBHFL.tbl_content_type_link>) new HashSet<IBHFL.tbl_content_type_link>();
      this.tbl_survey = (ICollection<IBHFL.tbl_survey>) new HashSet<IBHFL.tbl_survey>();
    }

    public int ID_CONTENT_ANSWER { get; set; }

    public int ID_CONTENT { get; set; }

    public string CONTENT_ANSWER_TITLE { get; set; }

    public string CONTENT_ANSWER_HEADER { get; set; }

    public string CONTENT_ANSWER1 { get; set; }

    public string CONTENT_ANSWER2 { get; set; }

    public string CONTENT_ANSWER3 { get; set; }

    public string CONTENT_ANSWER4 { get; set; }

    public string CONTENT_ANSWER_IMG1 { get; set; }

    public string CONTENT_ANSWER_IMG2 { get; set; }

    public string CONTENT_ANSWER_IMG3 { get; set; }

    public string CONTENT_ANSWER_BANNER { get; set; }

    public string REDIRECTION_URL { get; set; }

    public int CONTENT_ANSWER_COUNTER { get; set; }

    public string STATUS { get; set; }

    public DateTime UPDATEDTIME { get; set; }

    public string CONTENT_ANSWER10 { get; set; }

    public string CONTENT_ANSWER5 { get; set; }

    public string CONTENT_ANSWER6 { get; set; }

    public string CONTENT_ANSWER7 { get; set; }

    public string CONTENT_ANSWER8 { get; set; }

    public string CONTENT_ANSWER9 { get; set; }

    public string CONTENT_ANSWER_IMG10 { get; set; }

    public string CONTENT_ANSWER_IMG4 { get; set; }

    public string CONTENT_ANSWER_IMG5 { get; set; }

    public string CONTENT_ANSWER_IMG6 { get; set; }

    public string CONTENT_ANSWER_IMG7 { get; set; }

    public string CONTENT_ANSWER_IMG8 { get; set; }

    public string CONTENT_ANSWER_IMG9 { get; set; }

    public virtual ICollection<IBHFL.tbl_content_answer_steps> tbl_content_answer_steps { get; set; }

    public virtual ICollection<IBHFL.tbl_content_metadata> tbl_content_metadata { get; set; }

    public virtual ICollection<IBHFL.tbl_content_type_link> tbl_content_type_link { get; set; }

    public virtual ICollection<IBHFL.tbl_survey> tbl_survey { get; set; }
  }
}
