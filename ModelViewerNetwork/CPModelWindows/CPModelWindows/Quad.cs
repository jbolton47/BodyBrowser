#region File Description
//-----------------------------------------------------------------------------
// Quad.cs
//
// Microsoft XNA Community Game Platform
// Copyright (C) Microsoft Corporation. All rights reserved.
//-----------------------------------------------------------------------------
#endregion

using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace TexturedQuad
{
    public struct Quad
    {
        public Vector3 Origin;
        public Vector3 UpperLeft;
        public Vector3 LowerLeft;
        public Vector3 UpperRight;
        public Vector3 LowerRight;
        public Vector3 Normal;
        public Vector3 Up;
        public Vector3 Left;

        public VertexPositionNormalTexture[] Vertices;
//        public int[] Indexes;
        //public short[] Indexes;


        public Quad( Vector3 origin, Vector3 normal, Vector3 up, 
            float width, float height )
        {
            //Vertices = new VertexPositionNormalTexture[4];
            Vertices = new VertexPositionNormalTexture[101];
            //Indexes = new short[100];
            Origin = origin;
            Normal = normal;
            Up = up;

            // Calculate the quad corners
            Left = Vector3.Cross(normal, Up);
            Vector3 uppercenter = (Up * height / 2) + origin;
            UpperLeft = uppercenter + (Left * width / 2);
            UpperRight = uppercenter - (Left * width / 2);
            LowerLeft = UpperLeft - (Up * height);
            LowerRight = UpperRight - (Up * height);

            FillVertices();
        }
        
        private void FillVertices()
        {
            Vector2 textureUpperLeft = new Vector2(0.0f, 0.0f);
            Vector2 textureUpperRight = new Vector2(1.0f, 0.0f);
            Vector2 textureLowerLeft = new Vector2(0.0f, 1.0f);
            Vector2 textureLowerRight = new Vector2(1.0f, 1.0f);

            // Provide a normal for each vertex
            for (int i = 0; i < Vertices.Length; i++)
            {
                Vertices[i].Normal = Normal;
            }

            


            /*short j = 0;
            for (int i = 0; i < 99; i+=3)
            {
                float test = (float) i / 100;
                float angle = (float)(test * Math.PI * 2);
                Vertices[i].Position = new Vector3((float)Math.Cos(angle),(float)Math.Sin(angle), 0);
                Vertices[i + 1].Position = new Vector3(0, 0, 0);

                test = ((float)(i + 1)) / 100;
                angle = (float)(test * Math.PI * 2);

                Vertices[i + 2].Position = new Vector3((float)Math.Cos(angle), (float)Math.Sin(angle), 0);
                
                Indexes[i] = j;
                Indexes[i + 1] = j;
                Indexes[i + 2] = j;
                j++;
            }*/
            for (int i = 0; i < 99; i+=2)
            {
                float test = (float)i / 100;
                float angle = (float)(test * Math.PI);
                Vertices[i].Position = new Vector3((float)Math.Cos(angle) / 1.3333f , (float)Math.Sin(angle) / 1.333f, 0);
                Vertices[i].TextureCoordinate = new Vector2((float)i/100, 0);


                Vertices[i + 1].Position = new Vector3(((float)Math.Cos(angle) * .25f) / 1.3333f, ((float)Math.Sin(angle) / 1.333f) * .25f, 0);
                //Vertices[i + 1].TextureCoordinate = new Vector2((float)Math.Cos(angle) * .25f, ((float)Math.Sin(angle) / 1.333f) * .25f);
                Vertices[i + 1].TextureCoordinate = new Vector2(((float) i/100), 1);

            }
            Vertices[100] = Vertices[0];

            
            // Set the position and texture coordinate for each
            // vertex
            /*for (int i = 0; i < 99; i += 4)
            {
                Vertices[i].TextureCoordinate = textureLowerLeft;
                Vertices[i+1].TextureCoordinate = textureUpperLeft;
                Vertices[i+2].TextureCoordinate = textureLowerRight;
                Vertices[i+3].TextureCoordinate = textureUpperRight;
            }*/

            /*Vertices[0].TextureCoordinate = textureLowerLeft;
            Vertices[1].TextureCoordinate = textureUpperLeft;
            Vertices[42].TextureCoordinate = textureLowerRight;
            Vertices[43].TextureCoordinate = textureUpperRight;*/


            /*float test = (float)0 / 100;
            float angle = (float)(test * Math.PI * 2);
            Vertices[0].Position = new Vector3((float)Math.Cos(angle), (float)Math.Sin(angle), 0);
            Vertices[0].Color = Color.Red;

            Vertices[1].Position = new Vector3(0, 0, 0);
            Vertices[1].Color = Color.Green;

            test = (float)20.0f / 100.0f;
            angle = (float)(test * Math.PI * 2);
            Vertices[2].Position = new Vector3((float)Math.Cos(angle), (float)Math.Sin(angle), 0);


            test = (float)40.0f / 100.0f;
            angle = (float)(test * Math.PI * 2);
            Vertices[3].Position = new Vector3((float)Math.Cos(angle), (float)Math.Sin(angle), 0);

            //Vertices[2].Position = new Vector3(-1, 1, 0);

            test = 1;*/

            // Set the index buffer for each vertex, using
            // clockwise winding
            /*Indexes[0] = 0;
            Indexes[1] = 1;
            Indexes[2] = 2;
            Indexes[3] = 2;
            Indexes[4] = 1;
            Indexes[5] = 3;*/

            /*Indexes[0] = 0;
            Indexes[1] = 1;
            Indexes[2] = 2;
            Indexes[3] = 3;
            Indexes[4] = 4;
            Indexes[5] = 5;*/
        }
    }
}
