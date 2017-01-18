//-----------------------------------------------------------------------
// <copyright file="Specification.cs" company="Misc">
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
    /// This class allows access to the concept of typed or composite specifications.
    /// </summary>
    public static class Specification
    {
        /// <summary>
        /// This method makes it possible to compose specifications with the operator <c>and</c>.
        /// </summary>
        /// <typeparam name="TTarget">The type of objects that will be validated in the specification.</typeparam>
        /// <param name="specifications">The specifications to be composed.</param>
        /// <returns>A specification.</returns>
        public static SpecificationBase<TTarget> And<TTarget>(params ISpecification<TTarget>[] specifications)
        {
            return new AndSpecification<TTarget>(specifications);
        }

        /// <summary>
        /// This method makes it possible to compose specifications with the operator <c>|</c>.
        /// </summary>
        /// <typeparam name="TTarget">The type of objects that will be validated in the specification.</typeparam>
        /// <param name="specifications">The specifications to be composed.</param>
        /// <returns>A specification.</returns>
        public static SpecificationBase<TTarget> Or<TTarget>(params ISpecification<TTarget>[] specifications)
        {
            return new OrSpecification<TTarget>(specifications);
        }

        /// <summary>
        /// This method reverses a specification.
        /// </summary>
        /// <typeparam name="TTarget">The type of objects that will be validated in the specification.</typeparam>
        /// <param name="specification">The specification to invert.</param>
        /// <returns>A specification.</returns>
        public static SpecificationBase<TTarget> Not<TTarget>(ISpecification<TTarget> specification)
        {
            return new NotSpecification<TTarget>(specification);
        }

        /// <summary>
        /// This method returns an empty specification.
        /// </summary>
        /// <typeparam name="TTarget">The type of objects that will be validated in the specification.</typeparam>
        /// <returns>A specification.</returns>
        public static SpecificationBase<TTarget> Empty<TTarget>()
        {
            return new EmptySpecification<TTarget>();
        }
    }
}
