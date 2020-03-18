///
/// SharpWave - A refactored port of JWave
/// https://github.com/graetz23/JWave
///
/// MIT License
///
/// Copyright (c) 2020 Christian (graetz23@gmail.com)
///
/// Permission is hereby granted, free of charge, to any person obtaining a copy
/// of this software and associated documentation files (the "Software"), to deal
/// in the Software without restriction, including without limitation the rights
/// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
/// copies of the Software, and to permit persons to whom the Software is
/// furnished to do so, subject to the following conditions:
///
/// The above copyright notice and this permission notice shall be included in all
/// copies or substantial portions of the Software.
///
/// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
/// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
/// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
/// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
/// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
/// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
/// SOFTWARE.
///
using System;

namespace SharpWave
{

  ///<summary>
  /// Ingrid Daubechies' orthonormal Coiflet wavelet of twentyfour coefficients.
  ///</summary>
  ///<remarks>
  /// Christian (graetz23@gmail.com) 16.02.2014 01:46:11
  ///</remarks>
  public class Coiflet4 : Wavelet {

    ///<summary>
    /// Constructor calculating analytically the orthogonal Coiflet wavelet of
    /// twentyfour coefficients, orthonormalizes them (normed, due to ||*||2
    /// euclidean norm), and builds the scaling coefficients, and the
    /// orthonormal bases afterwards.
    ///</summary>
    ///<remarks>
    /// Christian (graetz23@gmail.com) 16.02.2014 01:46:11
    ///</remarks>
    public Coiflet4( ) : base( "Coiflet 4", 24, 2 ) {
      _scalingDeCom[ 0 ] = -1.7849850030882614e-06;
      _scalingDeCom[ 1 ] = -3.2596802368833675e-06;
      _scalingDeCom[ 2 ] = 3.1229875865345646e-05;
      _scalingDeCom[ 3 ] = 6.233903446100713e-05;
      _scalingDeCom[ 4 ] = -0.00025997455248771324;
      _scalingDeCom[ 5 ] = -0.0005890207562443383;
      _scalingDeCom[ 6 ] = 0.0012665619292989445;
      _scalingDeCom[ 7 ] = 0.003751436157278457;
      _scalingDeCom[ 8 ] = -0.00565828668661072;
      _scalingDeCom[ 9 ] = -0.015211731527946259;
      _scalingDeCom[ 10 ] = 0.025082261844864097;
      _scalingDeCom[ 11 ] = 0.03933442712333749;
      _scalingDeCom[ 12 ] = -0.09622044203398798;
      _scalingDeCom[ 13 ] = -0.06662747426342504;
      _scalingDeCom[ 14 ] = 0.4343860564914685;
      _scalingDeCom[ 15 ] = 0.782238930920499;
      _scalingDeCom[ 16 ] = 0.41530840703043026;
      _scalingDeCom[ 17 ] = -0.05607731331675481;
      _scalingDeCom[ 18 ] = -0.08126669968087875;
      _scalingDeCom[ 19 ] = 0.026682300156053072;
      _scalingDeCom[ 20 ] = 0.016068943964776348;
      _scalingDeCom[ 21 ] = -0.0073461663276420935;
      _scalingDeCom[ 22 ] = -0.0016294920126017326;
      _scalingDeCom[ 23 ] = 0.0008923136685823146;
      _buildBaseSystem( ); // build all other from low pass decomposition
    } // Coiflet4

  } // class

} // namespace
