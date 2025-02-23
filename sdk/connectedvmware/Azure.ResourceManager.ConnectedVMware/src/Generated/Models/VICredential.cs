// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ConnectedVMware.Models
{
    /// <summary> Username / Password Credentials to connect to vcenter. </summary>
    public partial class VICredential
    {
        /// <summary> Initializes a new instance of VICredential. </summary>
        public VICredential()
        {
        }

        /// <summary> Initializes a new instance of VICredential. </summary>
        /// <param name="username"> Gets or sets username to connect with the vCenter. </param>
        /// <param name="password"> Gets or sets the password to connect with the vCenter. </param>
        internal VICredential(string username, string password)
        {
            Username = username;
            Password = password;
        }

        /// <summary> Gets or sets username to connect with the vCenter. </summary>
        public string Username { get; set; }
        /// <summary> Gets or sets the password to connect with the vCenter. </summary>
        public string Password { get; set; }
    }
}
