// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.Sql.Models;

namespace Microsoft.Azure.Management.Sql
{
    /// <summary>
    /// Represents all the operations for managing Advisors for Azure SQL
    /// Databases. Contains operations to retrieve Advisors and update auto
    /// execute status of an Advisor.
    /// </summary>
    public partial interface IDatabaseAdvisorOperations
    {
        /// <summary>
        /// Returns details of a Database Advisor.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Resource Group.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Azure SQL server.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the Azure SQL database.
        /// </param>
        /// <param name='advisorName'>
        /// The name of the Azure SQL database advisor.
        /// </param>
        /// <param name='expand'>
        /// The comma separated list of child objects that we want to expand on
        /// in response. NULL if expand is not required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Represents the response to a get advisor request.
        /// </returns>
        Task<AdvisorGetResponse> GetAsync(string resourceGroupName, string serverName, string databaseName, string advisorName, string expand, CancellationToken cancellationToken);
        
        /// <summary>
        /// Returns list of Advisors for the Azure SQL Database.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Resource Group.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Azure SQL server.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the Azure SQL database.
        /// </param>
        /// <param name='expand'>
        /// The comma separated list of child objects that we want to expand on
        /// in response. NULL if expand is not required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Represents the response to a list sql azure database advisors
        /// request.
        /// </returns>
        Task<AdvisorListResponse> ListAsync(string resourceGroupName, string serverName, string databaseName, string expand, CancellationToken cancellationToken);
        
        /// <summary>
        /// Updates the auto-execute status for this Advisor.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Resource Group to which the Azure SQL Server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Azure SQL Server on which the database is hosted.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the Azure SQL Database.
        /// </param>
        /// <param name='advisorName'>
        /// The name of the Azure SQL Database advisor.
        /// </param>
        /// <param name='parameters'>
        /// The required parameters for updating auto-execute status of an
        /// Advisor
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Represents the response to a update advisor request.
        /// </returns>
        Task<AdvisorUpdateResponse> UpdateAsync(string resourceGroupName, string serverName, string databaseName, string advisorName, AdvisorUpdateParameters parameters, CancellationToken cancellationToken);
    }
}
