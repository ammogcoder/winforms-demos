#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MarketSimulation
{
#if SyncfusionFramework2_0
    class OrderAgreementListC : List<OrderAgreementC>
    {
    }
#else
    class OrderAgreementListC : ArrayList
    {
        public new OrderAgreementC this[int index]
        {
            get
            {
                return (OrderAgreementC) base[index];
            }
            set
            {
                base[index] = value;
            }
        }
    }
#endif
}
