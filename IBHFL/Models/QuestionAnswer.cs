﻿// Decompiled with JetBrains decompiler
// Type: IBHFL.Models.QuestionAnswer
// Assembly: IBHFL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7D5F13E8-66C2-4709-8C6B-C4D11A9CFC14
// Assembly location: D:\M2OST Desktop\console\bin\IBHFL.dll

using System.Collections.Generic;

namespace IBHFL.Models
{
  public class QuestionAnswer
  {
    public List<AssessmentQuestion> AssessmenQuestion { get; set; }

    public List<IBHFL.Models.AssessmentOption> AssessmentOption { get; set; }
  }
}