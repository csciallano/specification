//-----------------------------------------------------------------------
// <copyright file="EmptySpecification{TTarget}.cs" company="Misc">
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
    /// <summary>
    /// This class represents an empty specification.
    /// </summary>
    /// <typeparam name="TTarget">The object type the specification can target.</typeparam>
    public class EmptySpecification<TTarget> : SpecificationBase<TTarget>
    {
        /// <summary>
        /// Determines whether the target instance satisfies the specification.
        /// </summary>
        /// <param name="target">The instance to validate.</param>
        /// <returns>
        ///   <c>true</c> if the target satisfies the specification, otherwise, <c>false</c>.
        /// </returns>
        public override bool IsSatisfiedBy(TTarget target)
        {
            return true;
        }
    }
}
