//-----------------------------------------------------------------------
// <copyright file="ISpecification.cs" company="Misc">
//     Copyright (c) Clément Sciallano.
// </copyright>
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
//-----------------------------------------------------------------------

namespace Misc.Specification
{
    /// <summary>
    /// Defines a basic interface for specifications.
    /// Wikipedia: https://en.wikipedia.org/wiki/Specification_pattern.
    /// Martin Fowler: http://martinfowler.com/apsupp/spec.pdf.
    /// </summary>
    /// <typeparam name="TTarget">The object type the specification can target.</typeparam>
    public interface ISpecification<in TTarget>
    {
        /// <summary>
        /// Gets the reason of the specification validation failure.
        /// </summary>
        string NotSatisfiedReason
        {
            get;
        }

        /// <summary>
        /// Determines whether the target instance satisfies the specification.
        /// </summary>
        /// <param name="target">The instance to validate.</param>
        /// <returns>
        ///   <c>true</c> if the target satisfies the specification, otherwise, <c>false</c>.
        /// </returns>
        bool IsSatisfiedBy(TTarget target);
    }
}
