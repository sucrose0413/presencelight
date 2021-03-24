﻿namespace PresenceLight.Core
{
    public class ColorSubscription : Subscription
    {
        public bool Disabled { get; set; }

        public string? Colour { get; set; }

        public override bool IsValid() => Disabled || !string.IsNullOrWhiteSpace(Colour);
    }
}