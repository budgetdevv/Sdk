﻿// Copyright (c) 2020-2021, Els_kom org.
// https://github.com/Elskom/
// All rights reserved.
// license: see LICENSE for more details.

namespace Elskom.Generic.Libs.UnluacNET
{
    using System.Diagnostics.CodeAnalysis;

    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:Elements should be documented", Justification = "No docs yet.")]
    public class UpvalueExpression : Expression
    {
        [SuppressMessage("StyleCop.CSharp.NamingRules", "SA1308:Variable names should not be prefixed", Justification = "Don't care for now.")]
        private readonly string m_name;

        public UpvalueExpression(string name)
            : base(PRECEDENCE_ATOMIC)
            => this.m_name = name;

        public override int ConstantIndex => -1;

        public override bool IsBrief => true;

        public override bool IsDotChain => true;

        public override void Print(Output output)
            => output.Print(this.m_name);
    }
}
