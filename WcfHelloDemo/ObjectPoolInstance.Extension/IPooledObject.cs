﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectPoolInstance.Extension
{
	public interface IPooledObject
	{
		bool IsBusy { get; set; }
	}
}
