//-----------------------------------------------------------------------
// <copyright file="AndSpecification{TTarget}.cs" company="Misc">
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
    using System.Linq;

    /// <summary>
    /// Cette classe décrit une spécification qui permet de s'assurer que tous les membres (spécifications) contenus sont valides.
    /// </summary>
    /// <typeparam name="TTarget">The object type the specification can target.</typeparam>
    public class AndSpecification<TTarget> : AbstractCompositeSpecification<TTarget>
    {
        /// <summary>
        /// Initializes a new instance of the class <see cref="AndSpecification{TTarget}"/>.
        /// </summary>
        /// <param name="specifications">Specifications that must be validated.</param>
        public AndSpecification(params ISpecification<TTarget>[] specifications)
            : base(specifications)
        {
        }

        /// <summary>
        /// This method ensures that all specifications provided are valid.
        /// </summary>
        /// <param name="target">The entity targeted by the specification.</param>
        /// <returns><c>true</c> if the specifications are valid, <c>false</c>, otherwise.</returns>
        public override bool IsSatisfiedBy(TTarget target)
        {
            return this.Specifications.All((s) => s.IsSatisfiedBy(target));
        }
    }
}
