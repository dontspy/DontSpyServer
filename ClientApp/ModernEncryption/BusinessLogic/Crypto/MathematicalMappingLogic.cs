﻿using System.Collections.Generic;
using ModernEncryption.Model;

namespace ModernEncryption.BusinessLogic.Crypto
{
    internal class MathematicalMappingLogic
    {
        public static Dictionary<char, Interval> IntervalTable { get; set; } = new Dictionary<char, Interval>();
        public static Dictionary<int, char> TransformationTable { get; set; } = new Dictionary<int, char>();
        public static Dictionary<char, int> BackTransformationTable { get; set; } = new Dictionary<char, int>();

        public void InitalizeIntervalTable()
        {
            var A = new Interval(1, 8);

            var a = new Interval(9, 84);

            var B = new Interval(85, 86);

            var b = new Interval(87, 108);

            var C = new Interval(109, 111);

            var c = new Interval(112, 147);

            var D = new Interval(148, 153);

            var d = new Interval(154, 213);

            var E = new Interval(214, 235);

            var e = new Interval(236, 439);

            var F = new Interval(440, 441);

            var f = new Interval(442, 460);

            var G = new Interval(461, 463);

            var g = new Interval(464, 499);

            var H = new Interval(500, 504);

            var h = new Interval(506, 561);

            var I = new Interval(562, 570);

            var i = new Interval(571, 659);

            var J = new Interval(660, 660);

            var j = new Interval(661, 662);

            var K = new Interval(663, 663);

            var k = new Interval(664, 677);

            var L = new Interval(678, 681);

            var l = new Interval(682, 721);

            var M = new Interval(722, 724);

            var m = new Interval(725, 753);

            var N = new Interval(754, 765);

            var n = new Interval(766, 880);

            var O = new Interval(881, 882);

            var o = new Interval(882, 912);

            var P = new Interval(913, 913);

            var p = new Interval(914, 922);

            var Q = new Interval(505, 505);

            var q = new Interval(923, 923);

            var R = new Interval(924, 931);

            var r = new Interval(933, 1014);

            var S = new Interval(1015, 1023);

            var s = new Interval(1024, 1108);

            var T = new Interval(1109, 1115);

            var t = new Interval(1117, 1188);

            var U = new Interval(1189, 1193);

            var u = new Interval(1194, 1244);

            var V = new Interval(1245, 1245);

            var v = new Interval(1246, 1252);

            var W = new Interval(1253, 1254);

            var w = new Interval(1255, 1276);

            var X = new Interval(932, 932);

            var x = new Interval(1277, 1277);

            var Y = new Interval(1116, 1116);

            var y = new Interval(1278, 1278);

            var Z = new Interval(1279, 1279);

            var z = new Interval(1280, 1292);

            var sharpS = new Interval(1293, 1296);

            var dot = new Interval(1297, 1312);

            var comma = new Interval(1313, 1335);

            var space = new Interval(1336, 1590);

            var one = new Interval(1591, 1591);

            var two = new Interval(1592, 1592);

            var three = new Interval(1593, 1593);

            var four = new Interval(1594, 1594);

            var five = new Interval(1595, 1595);

            var six = new Interval(1596, 1596);

            var seven = new Interval(1597, 1597);

            var eight = new Interval(1598, 1598);

            var nine = new Interval(1599, 1599);

            var zero = new Interval(1600, 1600);

            IntervalTable.Add('a', a);
            IntervalTable.Add('b', b);
            IntervalTable.Add('c', c);
            IntervalTable.Add('d', d);
            IntervalTable.Add('e', e);
            IntervalTable.Add('f', f);
            IntervalTable.Add('g', g);
            IntervalTable.Add('h', h);
            IntervalTable.Add('i', i);
            IntervalTable.Add('j', j);
            IntervalTable.Add('k', k);
            IntervalTable.Add('l', l);
            IntervalTable.Add('m', m);
            IntervalTable.Add('n', n);
            IntervalTable.Add('o', o);
            IntervalTable.Add('p', p);
            IntervalTable.Add('q', q);
            IntervalTable.Add('r', r);
            IntervalTable.Add('s', s);
            IntervalTable.Add('t', t);
            IntervalTable.Add('u', u);
            IntervalTable.Add('v', v);
            IntervalTable.Add('w', w);
            IntervalTable.Add('x', x);
            IntervalTable.Add('y', y);
            IntervalTable.Add('z', z);
            IntervalTable.Add('A', A);
            IntervalTable.Add('B', B);
            IntervalTable.Add('C', C);
            IntervalTable.Add('D', D);
            IntervalTable.Add('E', E);
            IntervalTable.Add('F', F);
            IntervalTable.Add('G', G);
            IntervalTable.Add('H', H);
            IntervalTable.Add('I', I);
            IntervalTable.Add('J', J);
            IntervalTable.Add('K', K);
            IntervalTable.Add('L', L);
            IntervalTable.Add('M', M);
            IntervalTable.Add('N', N);
            IntervalTable.Add('O', O);
            IntervalTable.Add('P', P);
            IntervalTable.Add('Q', Q);
            IntervalTable.Add('R', R);
            IntervalTable.Add('S', S);
            IntervalTable.Add('T', T);
            IntervalTable.Add('U', U);
            IntervalTable.Add('V', V);
            IntervalTable.Add('W', W);
            IntervalTable.Add('X', X);
            IntervalTable.Add('Y', Y);
            IntervalTable.Add('Z', Z);
            IntervalTable.Add('ß', sharpS);
            IntervalTable.Add('.', dot);
            IntervalTable.Add(',', comma);
            IntervalTable.Add(' ', space);
            IntervalTable.Add('1', one);
            IntervalTable.Add('2', two);
            IntervalTable.Add('3', three);
            IntervalTable.Add('4', four);
            IntervalTable.Add('5', five);
            IntervalTable.Add('6', six);
            IntervalTable.Add('7', seven);
            IntervalTable.Add('8', eight);
            IntervalTable.Add('9', nine);
            IntervalTable.Add('0', zero);
        }

        public void InitalizeTransformationTable()
        {
            TransformationTable.Add(1, 'a');
            TransformationTable.Add(2, 'b');
            TransformationTable.Add(3, 'c');
            TransformationTable.Add(4, 'd');
            TransformationTable.Add(5, 'e');
            TransformationTable.Add(6, 'f');
            TransformationTable.Add(7, 'g');
            TransformationTable.Add(8, 'h');
            TransformationTable.Add(9, 'i');
            TransformationTable.Add(10, 'j');
            TransformationTable.Add(11, 'k');
            TransformationTable.Add(12, 'l');
            TransformationTable.Add(13, 'm');
            TransformationTable.Add(14, 'n');
            TransformationTable.Add(15, 'o');
            TransformationTable.Add(16, 'p');
            TransformationTable.Add(17, 'q');
            TransformationTable.Add(18, 'r');
            TransformationTable.Add(19, 's');
            TransformationTable.Add(20, 't');
            TransformationTable.Add(21, 'u');
            TransformationTable.Add(22, 'v');
            TransformationTable.Add(23, 'w');
            TransformationTable.Add(24, 'x');
            TransformationTable.Add(25, 'y');
            TransformationTable.Add(26, 'z');
            TransformationTable.Add(27, 'ß');
            TransformationTable.Add(28, '.');
            TransformationTable.Add(29, ',');
            TransformationTable.Add(30, ' ');
            TransformationTable.Add(31, '1');
            TransformationTable.Add(32, '2');
            TransformationTable.Add(33, '3');
            TransformationTable.Add(34, '4');
            TransformationTable.Add(35, '5');
            TransformationTable.Add(36, '6');
            TransformationTable.Add(37, '7');
            TransformationTable.Add(38, '8');
            TransformationTable.Add(39, '9');
            TransformationTable.Add(40, '0');
        }
    }
}
