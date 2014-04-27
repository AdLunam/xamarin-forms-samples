using System;
using System.Collections;
using Xamarin.QuickUI;
using System.Collections.Generic;

namespace Meetum.Controls
{
    public class CarouselEventArgs : EventArgs
	{
        public int OldPage { get; private set; }
        public int NewPage { get; private set; }
	}
}

