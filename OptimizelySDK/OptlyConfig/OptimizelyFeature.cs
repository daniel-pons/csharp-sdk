﻿/* 
 * Copyright 2019, 2021, Optimizely
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using System;
using System.Collections.Generic;

namespace OptimizelySDK.OptlyConfig
{
    public class OptimizelyFeature : Entity.IdKeyEntity
    {
        
        public List<OptimizelyExperiment> ExperimentRules { get; private set; }
        public List<OptimizelyExperiment> DeliveryRules { get; private set; }

        [Obsolete("Use experimentRules and deliveryRules.")]
        public IDictionary<string, OptimizelyExperiment> ExperimentsMap { get; private set; }
        public IDictionary<string, OptimizelyVariable> VariablesMap { get; private set; }

        public OptimizelyFeature(string id, string key, List<OptimizelyExperiment> experimentRules, List<OptimizelyExperiment> deliveryRules, IDictionary<string, OptimizelyExperiment> experimentsMap, IDictionary<string, OptimizelyVariable> variablesMap)
        {
            Id = id;
            Key = key;
            ExperimentRules = experimentRules;
            DeliveryRules = deliveryRules;
            ExperimentsMap = experimentsMap;
            VariablesMap = variablesMap;
        }
    }
}
