﻿// Decompiled with JetBrains decompiler
// Type: IBHFL.Models.EventResponse
// Assembly: IBHFL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7D5F13E8-66C2-4709-8C6B-C4D11A9CFC14
// Assembly location: D:\M2OST Desktop\console\bin\IBHFL.dll

using System.Collections.Generic;

namespace IBHFL.Models
{
  public class EventResponse
  {
    public List<EventThumbnail> READ { get; set; }

    public List<EventThumbnail> UNREAD { get; set; }
  }
}
