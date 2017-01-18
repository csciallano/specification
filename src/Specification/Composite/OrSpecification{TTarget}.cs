//-----------------------------------------------------------------------
// <copyright file="OrSpecification{TTarget}.cs" company="Misc">
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
    /// Cette classe permet de vérifier qu'au moins une des spécifications fournies est valide.
    /// </summary>
    /// <typeparam name="TTarget">Le type d'entité ciblé par la spécification.</typeparam>
    public class OrSpecification<TTarget> : AbstractCompositeSpecification<TTarget>
    {
        /// <summary>
        /// Initializes a new instance of the class <see cref="OrSpecification{TTarget}"/>.
        /// </summary>
        /// <param name="specifications">Specifications to be validated.</param>
        public OrSpecification(params ISpecification<TTarget>[] specifications)
            : base(specifications)
        {
        }
                
        /// <summary>
        /// This method ensures that at least one specification is valid.
        /// </summary>
        /// <param name="target">The instance to validate.</param>
        /// <returns>
        ///   <c>true</c> if the target satisfies the specification, otherwise, <c>false</c>.
        /// </returns>
        public override bool IsSatisfiedBy(TTarget target)
        {
            return this.Specifications.Any((s) => s.IsSatisfiedBy(target));
        }
    }
}
