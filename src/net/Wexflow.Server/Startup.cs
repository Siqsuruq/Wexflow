﻿using Owin;

namespace Wexflow.Server
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            _ = app.UseNancy();
        }
    }
}
