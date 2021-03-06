//
// WorkFinishedEventArgs.cs
//
// Author:
//   Vladimir Dimitrov <vdimitrov at vladster dot net>
//
// Created:
//   07/11/2009
//
// 2006-2015 (C) Microinvest, http://www.microinvest.net
//
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA

using System;
using System.Threading;

namespace Warehouse.Data.ThreadPool
{
    public class WorkFinishedEventArgs : EventArgs
    {
        private readonly ThreadState state;
        private readonly Exception exception;

        public ThreadState State
        {
            get { return state; }
        }

        public Exception Exception
        {
            get { return exception; }
        }

        internal WorkFinishedEventArgs (ThreadState state, Exception exception)
        {
            this.state = state;
            this.exception = exception;
        }
    }
}
