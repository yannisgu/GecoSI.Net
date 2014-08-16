GecoSI
======

Copyright (c) 2013-2014 Simon Denier & Yannis Guedel.

Open-source C#.NET library to use the SPORTident timing system.

Distributed under the MIT license (see LICENSE file).

Some parts released by SPORTident under the CC BY 3.0 license. http://creativecommons.org/licenses/by/3.0/

Usage (Library)
===============

- `SiHandler#Connect` is the entry point (see `ConsoleApplication#Main` for a basic client)
- Client should provide a `SiListener` implementation to `SiHandler`
- `SiListener` is notified with station status (`CommStatus`) and SiCard dataframes (`SiDataFrame` and `SiPunch`)
- That's all you need to know!

