﻿// Decompiled with JetBrains decompiler
// Type: IBHFL.tbl_role
// Assembly: IBHFL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7D5F13E8-66C2-4709-8C6B-C4D11A9CFC14
// Assembly location: D:\M2OST Desktop\console\bin\IBHFL.dll

using System;

namespace IBHFL
{
  public class tbl_role
  {
    public int ID_ROLE { get; set; }

    public int ID_ORGANIZATION { get; set; }

    public string ROLENAME { get; set; }

    public string DESCRIPTION { get; set; }

    public string STATUS { get; set; }

    public DateTime UPDATEDTIME { get; set; }

    public virtual tbl_organization tbl_organization { get; set; }
  }
}
