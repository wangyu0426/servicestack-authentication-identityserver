﻿namespace UserAuthProvider.ServiceStack.Core.SelfHost.ServiceInterface
{
    using global::ServiceStack;
    using global::ServiceStack.Core.Authentication.IdentityServer.Providers;
    using ServiceModel;

    public class MyServices : Service
    {
        [Authenticate(IdentityServerAuthProvider.Name)]
        public object Get(Hello request)
        {
            var session = GetSession();

            return new HelloResponse { Result = $"Hello, {session.FirstName}!" };
        }

        public object Post(Hello request)
        {
            return new HelloResponse { Result = $"Hello, {request.Name}!" };
        }
    }
}