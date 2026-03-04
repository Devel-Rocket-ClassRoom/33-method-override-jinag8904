using System;

Instrument[] instruments = { new Piano(), new Guitar(), new Drum() };

foreach (Instrument instr in instruments)
{
    instr.Tune();
    instr.Play();
}