//-----------------------------------------------------------------------
// <copyright file="SpecificationBase{TTarget}.cs" company="Misc">
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
    using Composite;

    /// <summary>
    /// Defines a base class for the specifications.
    /// </summary>
    /// <typeparam name="TTarget">The target object type that the specification can check.</typeparam>
    public abstract class SpecificationBase<TTarget> : ISpecification<TTarget>
    {
        /// <summary>
        /// Gets or sets the reason for the failure to comply with the specification.
        /// </summary>
        public string NotSatisfiedReason
        {
            get; protected set;
        }

        /// <summary>
        /// Overrides operator <c>and</c> to compose specifications and verify that they all meet their condition.
        /// </summary>
        /// <param name="left">The left member of the composition.</param>
        /// <param name="right">The right member of the composition.</param>
        /// <returns>A composed specification.</returns>
        public static SpecificationBase<TTarget> operator &(SpecificationBase<TTarget> left, SpecificationBase<TTarget> right)
        {
            return new AndSpecification<TTarget>(left, right);
        }

        /// <summary>
        /// Overrides operator <c>|</c> allowing to compose specifications and to verify that at least one of them satisfies its condition.
        /// </summary>
        /// <param name="left">The left member of the composition.</param>
        /// <param name="right">The right member of the composition.</param>
        /// <returns>A composed specification.</returns>
        public static SpecificationBase<TTarget> operator |(SpecificationBase<TTarget> left, SpecificationBase<TTarget> right)
        {
            return new OrSpecification<TTarget>(left, right);
        }

        /// <summary>
        /// Overrides operator <c>!</c> allowing to validate the inverse of the specification provided.
        /// </summary>
        /// <param name="specification">A specification.</param>
        /// <returns>An inverted specification.</returns>
        public static SpecificationBase<TTarget> operator !(SpecificationBase<TTarget> specification)
        {
            return new NotSpecification<TTarget>(specification);
        }

        /// <summary>
        /// Determines whether the target instance satisfies the specification.
        /// </summary>
        /// <param name="target">The instance to validate.</param>
        /// <returns>
        ///   <c>true</c> if the target satisfies the specification, otherwise, <c>false</c>.
        /// </returns>
        public abstract bool IsSatisfiedBy(TTarget target);
    }
}
