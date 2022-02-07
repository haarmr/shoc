﻿namespace Shoc.Builder.Model
{
    /// <summary>
    /// The docker registry creating model
    /// </summary>
    public class CreateDockerRegistry
    {
        /// <summary>
        /// The registry id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The registry uri value
        /// </summary>
        public string RegistryUri { get; set; }

        /// <summary>
        /// The registry email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The username value
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// The password in plain text form
        /// </summary>
        public string PasswordPlaintext { get; set; }

        /// <summary>
        /// The password in encrypted form
        /// </summary>
        public byte[] EncryptedPassword { get; set; }
    }
}