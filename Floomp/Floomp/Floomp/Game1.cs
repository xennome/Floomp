using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Input.Touch;
using Microsoft.Xna.Framework.Media;

namespace Floomp
{
    /// <summary>
    /// Tipo principal del juego
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            // La velocidad de fotogramas predeterminada para Windows Phone es de 30 fps.
            TargetElapsedTime = TimeSpan.FromTicks(333333);

            // Amplía la duración de la batería con bloqueo.
            InactiveSleepTime = TimeSpan.FromSeconds(1);
        }

        /// <summary>
        /// Permite que el juego realice la inicialización que necesite para empezar a ejecutarse.
        /// Aquí es donde puede solicitar cualquier servicio que se requiera y cargar todo tipo de contenido
        /// no relacionado con los gráficos. Si se llama a base.Initialize, todos los componentes se enumerarán
        /// e inicializarán.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: agregue aquí su lógica de inicialización

            base.Initialize();
        }

        /// <summary>
        /// LoadContent se llama una vez por juego y permite cargar
        /// todo el contenido.
        /// </summary>
        protected override void LoadContent()
        {
            // Crea un SpriteBatch nuevo para dibujar texturas.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content para cargar aquí el contenido del juego
        }

        /// <summary>
        /// UnloadContent se llama una vez por juego y permite descargar
        /// todo el contenido.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: descargue aquí todo el contenido que no pertenezca a ContentManager
        }

        /// <summary>
        /// Permite al juego ejecutar lógica para, por ejemplo, actualizar el mundo,
        /// buscar colisiones, recopilar entradas y reproducir audio.
        /// </summary>
        /// <param name="gameTime">Proporciona una instantánea de los valores de tiempo.</param>
        protected override void Update(GameTime gameTime)
        {
            // Permite salir del juego
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: agregue aquí su lógica de actualización

            base.Update(gameTime);
        }

        /// <summary>
        /// Se llama cuando el juego debe realizar dibujos por sí mismo.
        /// </summary>
        /// <param name="gameTime">Proporciona una instantánea de los valores de tiempo.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: agregue aquí el código de dibujo

            base.Draw(gameTime);
        }
    }
}
