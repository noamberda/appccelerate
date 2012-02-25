//-------------------------------------------------------------------------------
// <copyright file="IManageEventBroker.cs" company="Appccelerate">
//   Copyright (c) 2008-2012
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
//-------------------------------------------------------------------------------

namespace Appccelerate.DistributedEventBroker
{
    using EventBroker;

    /// <summary>
    /// Interface which defines a component which manages a single event broker.
    /// </summary>
    public interface IManageEventBroker
    {
        /// <summary>
        /// Manages the specified event broker.
        /// </summary>
        /// <param name="eventBroker">The event broker.</param>
        void Manage(IEventBroker eventBroker);

        /// <summary>
        /// Manages the specified event broker.
        /// </summary>
        /// <param name="eventBroker">The event broker.</param>
        /// <param name="eventBrokerIdentification">The event broker identification.</param>
        void Manage(IEventBroker eventBroker, string eventBrokerIdentification);
    }
}