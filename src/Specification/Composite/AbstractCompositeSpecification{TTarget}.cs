//-----------------------------------------------------------------------
// <copyright file="AbstractCompositeSpecification{TTarget}.cs" company="Misc">
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

namespace Misc.Specification.Composite
{
    using System.Collections.Generic;

    /// <summary>
    /// This abstract class allows you to group specifications.
    /// </summary>
    /// <typeparam name="TTarget">The entity type targeted by the specification.</typeparam>
    public abstract class AbstractCompositeSpecification<TTarget> : SpecificationBase<TTarget>
    {
        /// <summary>
        /// This collection represents the various specifications grouped together into one.
        /// </summary>
        private readonly ICollection<ISpecification<TTarget>> specifications;

        /// <summary>
        /// Initializes a new instance of the class <see cref="AbstractCompositeSpecification{TTarget}"/>.
        /// </summary>
        /// <param name="specifications">La liste spécifications de la composition.</param>
        protected AbstractCompositeSpecification(ICollection<ISpecification<TTarget>> specifications)
        {
            this.specifications = specifications;
        }

        /// <summary>
        /// Gets the list of specifications. 
        /// </summary>
        public IEnumerable<ISpecification<TTarget>> Specifications
        {
            get
            {
                return this.specifications;
            }
        }
    }
}
