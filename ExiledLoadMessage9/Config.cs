﻿using Exiled.API.Interfaces;

namespace ExiledLoadMessage
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;
        public string LoadText { get; set; } = "EXILED 10.0.0 SexUpdate\n" +
"   ▄███████▄  ▄██████▄     ▄████████ ███▄▄▄▄           ▄█    █▄    ███    █▄  ▀█████████▄  \n" +
"  ███    ███ ███    ███   ███    ███ ███▀▀▀██▄        ███    ███   ███    ███   ███    ███ \n" +
"  ███    ███ ███    ███   ███    ███ ███   ███        ███    ███   ███    ███   ███    ███ \n" +
"  ███    ███ ███    ███  ▄███▄▄▄▄██▀ ███   ███       ▄███▄▄▄▄███▄▄ ███    ███  ▄███▄▄▄██▀  \n" +
"▀█████████▀  ███    ███ ▀▀███▀▀▀▀▀   ███   ███      ▀▀███▀▀▀▀███▀  ███    ███ ▀▀███▀▀▀██▄  \n" +
"  ███        ███    ███ ▀███████████ ███   ███        ███    ███   ███    ███   ███    ██▄ \n" +
"  ███        ███    ███   ███    ███ ███   ███        ███    ███   ███    ███   ███    ███ \n" +
" ▄████▀       ▀██████▀    ███    ███  ▀█   █▀         ███    █▀    ████████▀  ▄█████████▀  \n" +
"                          ███    ███                                                       ";
    }
}
