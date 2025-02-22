// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary>
    /// Defines workload agnostic properties for a job.
    /// Please note <see cref="BackupGenericJob"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="IaasVmBackupJob"/>, <see cref="IaasVmBackupJobV2"/>, <see cref="StorageBackupJob"/>, <see cref="WorkloadBackupJob"/>, <see cref="DpmBackupJob"/>, <see cref="MabBackupJob"/> and <see cref="VaultBackupJob"/>.
    /// </summary>
    public abstract partial class BackupGenericJob
    {
        /// <summary> Initializes a new instance of BackupGenericJob. </summary>
        protected BackupGenericJob()
        {
        }

        /// <summary> Initializes a new instance of BackupGenericJob. </summary>
        /// <param name="entityFriendlyName"> Friendly name of the entity on which the current job is executing. </param>
        /// <param name="backupManagementType"> Backup management type to execute the current job. </param>
        /// <param name="operation"> The operation name. </param>
        /// <param name="status"> Job status. </param>
        /// <param name="startOn"> The start time. </param>
        /// <param name="endOn"> The end time. </param>
        /// <param name="activityId"> ActivityId of job. </param>
        /// <param name="jobType"> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </param>
        internal BackupGenericJob(string entityFriendlyName, BackupManagementType? backupManagementType, string operation, string status, DateTimeOffset? startOn, DateTimeOffset? endOn, string activityId, string jobType)
        {
            EntityFriendlyName = entityFriendlyName;
            BackupManagementType = backupManagementType;
            Operation = operation;
            Status = status;
            StartOn = startOn;
            EndOn = endOn;
            ActivityId = activityId;
            JobType = jobType;
        }

        /// <summary> Friendly name of the entity on which the current job is executing. </summary>
        public string EntityFriendlyName { get; set; }
        /// <summary> Backup management type to execute the current job. </summary>
        public BackupManagementType? BackupManagementType { get; set; }
        /// <summary> The operation name. </summary>
        public string Operation { get; set; }
        /// <summary> Job status. </summary>
        public string Status { get; set; }
        /// <summary> The start time. </summary>
        public DateTimeOffset? StartOn { get; set; }
        /// <summary> The end time. </summary>
        public DateTimeOffset? EndOn { get; set; }
        /// <summary> ActivityId of job. </summary>
        public string ActivityId { get; set; }
        /// <summary> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </summary>
        internal string JobType { get; set; }
    }
}
