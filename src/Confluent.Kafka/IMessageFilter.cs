// Copyright 2018 Confluent Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// Refer to LICENSE for more information.

namespace Confluent.Kafka
{
    /// <summary>
    /// Defines a filter that will cause consumers to skip deserialization of a message
    /// that does not meet the filter criteria.
    /// </summary>
    public interface IMessageFilter
    {
        /// <summary>
        /// Predicate returns whether or not the incoming message should be handled.
        /// </summary>
        /// <param name="incomingMessageHeaders">The incoming message headers.</param>
        /// <returns></returns>
        bool ShouldDeserialize(Headers incomingMessageHeaders);
    }

    /// <summary>
    /// Default implementation of a message filter always returns <c>true</c>.
    /// </summary>
    internal class DefaultMessageFilter : IMessageFilter
    {
        /// <inheritdoc />
        public bool ShouldDeserialize(Headers incomingMessageHeaders) => true;
    }
}
