// Copyright (C) 2015 Dmitry Yakimenko (detunized@gmail.com).
// Licensed under the terms of the MIT license. See LICENCE for details.

namespace PasswordBox
{
    public class Session
    {
        public Session(string id, byte[] key)
        {
            Id = id;
            Key = key;
        }

        public string Id { get; private set; }
        public byte[] Key { get; private set; }
    }
}
