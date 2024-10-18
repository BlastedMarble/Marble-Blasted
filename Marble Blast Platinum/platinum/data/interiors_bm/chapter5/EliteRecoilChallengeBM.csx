<?xml version="1.0" encoding="utf-8" standalone="yes" ?>
<!--Torque Constructor Scene document http://www.garagegames.com-->
<ConstructorScene version="4" creator="Torque Constructor" date="2024/10/11 22:03:16">
    <Sunlight azimuth="180" elevation="35" color="255 255 255" ambient="64 64 64" />
    <LightingOptions lightingSystem="" ineditor_defaultLightmapSize="256" ineditor_maxLightmapSize="256" ineditor_lightingPerformanceHint="0" ineditor_shadowPerformanceHint="1" ineditor_TAPCompatibility="0" ineditor_useSunlight="0" export_defaultLightmapSize="256" export_maxLightmapSize="256" export_lightingPerformanceHint="0" export_shadowPerformanceHint="1" export_TAPCompatibility="0" export_useSunlight="0" />
    <GameTypes>
        <GameType name="Constructor" />
        <GameType name="Torque" />
    </GameTypes>
    <DetailLevels current="0">
        <DetailLevel minPixelSize="0" actionCenter="0 0 0">
            <InteriorMap brushScale="32" lightScale="32" ambientColor="0 0 0" ambientColorEmerg="0 0 0">
                <Entities nextEntityID="1">
                    <Entity id="0" classname="worldspawn" gametype="Torque" isPointEntity="0">
                        <Properties detail_number="0" min_pixels="250" geometry_scale="32" light_geometry_scale="32" ambient_color="0 0 0" emergency_ambient_color="0 0 0" mapversion="220" />
                    </Entity>
                </Entities>
                <Brushes nextBrushID="259">
                    <Brush id="0" owner="0" type="0" pos="-1 3 0" rot="1 0 0 0" scale="" transform="1 0 0 -1 0 1 0 3 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 5 1" />
                            <Vertex pos="3 5 -1" />
                            <Vertex pos="3 -5 1" />
                            <Vertex pos="3 -5 -1" />
                            <Vertex pos="-3 5 1" />
                            <Vertex pos="-3 5 -1" />
                            <Vertex pos="-3 -5 1" />
                            <Vertex pos="-3 -5 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 384 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 -384 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -5" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile03_A" texgens="1 0 0 -256 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="1" owner="0" type="0" pos="-3 36 -3" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 36 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 6 14" />
                            <Vertex pos="3 6 -14" />
                            <Vertex pos="3 -6 14" />
                            <Vertex pos="3 -6 -14" />
                            <Vertex pos="-3 6 14" />
                            <Vertex pos="-3 6 -14" />
                            <Vertex pos="-3 -6 14" />
                            <Vertex pos="-3 -6 -14" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 512 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -14" album="" material="bm_tile03_A" texgens="1 0 0 -256 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="2" owner="0" type="0" pos="-8 45 -3" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 45 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8 3 14" />
                            <Vertex pos="8 3 -14" />
                            <Vertex pos="8 -3 14" />
                            <Vertex pos="8 -3 -14" />
                            <Vertex pos="-8 3 14" />
                            <Vertex pos="-8 3 -14" />
                            <Vertex pos="-8 -3 14" />
                            <Vertex pos="-8 -3 -14" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -8" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -8" album="" material="bm_grid_blank4" texgens="0 -1 0 -128 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -14" album="" material="bm_tile03_A" texgens="1 0 0 -1536 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="3" owner="0" type="0" pos="-25 47 -5" rot="1 0 0 0" scale="" transform="1 0 0 -25 0 1 0 47 0 0 1 -5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 12" />
                            <Vertex pos="3 3 -12" />
                            <Vertex pos="3 -3 10" />
                            <Vertex pos="3 -3 -12" />
                            <Vertex pos="-3 3 12" />
                            <Vertex pos="-3 3 -12" />
                            <Vertex pos="-3 -3 10" />
                            <Vertex pos="-3 -3 -12" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 -128 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.316228 0.948683 -10.4355" album="" material="bm_friction_ice" texgens="1 0 0 -256 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -12" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="4" owner="0" type="0" pos="-37 43 -6" rot="1 0 0 0" scale="" transform="1 0 0 -37 0 1 0 43 0 0 1 -6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 9" />
                            <Vertex pos="3 3 -11" />
                            <Vertex pos="3 -3 11" />
                            <Vertex pos="3 -3 -11" />
                            <Vertex pos="-3 3 9" />
                            <Vertex pos="-3 3 -11" />
                            <Vertex pos="-3 -3 11" />
                            <Vertex pos="-3 -3 -11" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 -128 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.316228 0.948683 -9.48683" album="" material="bm_friction_ice" texgens="1 0 0 -256 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -11" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="5" owner="0" type="0" pos="-50 50 -8" rot="1 0 0 0" scale="" transform="1 0 0 -50 0 1 0 50 0 0 1 -8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 6 9" />
                            <Vertex pos="4 6 -9" />
                            <Vertex pos="4 -6 9" />
                            <Vertex pos="4 -6 -9" />
                            <Vertex pos="-4 6 9" />
                            <Vertex pos="-4 6 -9" />
                            <Vertex pos="-4 -6 9" />
                            <Vertex pos="-4 -6 -9" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -9" album="" material="bm_tile03_A" texgens="1 0 0 -512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -9" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="6" owner="0" type="0" pos="-58 40 -5" rot="1 0 0 0" scale="" transform="1 0 0 -58 0 1 0 40 0 0 1 -5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 8 12" />
                            <Vertex pos="4 8 -12" />
                            <Vertex pos="4 -8 12" />
                            <Vertex pos="4 -8 -12" />
                            <Vertex pos="-4 8 12" />
                            <Vertex pos="-4 8 -12" />
                            <Vertex pos="-4 -8 12" />
                            <Vertex pos="-4 -8 -12" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -1280 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 1280 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -12" album="" material="bm_tile03_A" texgens="1 0 0 -512 0 -1 0 3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -12" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="7" owner="0" type="0" pos="-56 52 -8" rot="1 0 0 0" scale="" transform="1 0 0 -56 0 1 0 52 0 0 1 -8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 9" />
                            <Vertex pos="2 4 -9" />
                            <Vertex pos="2 -4 9" />
                            <Vertex pos="2 -4 -9" />
                            <Vertex pos="-2 4 9" />
                            <Vertex pos="-2 4 -9" />
                            <Vertex pos="-2 -4 9" />
                            <Vertex pos="-2 -4 -9" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -9" album="" material="bm_tile03_A" texgens="1 0 0 0 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -9" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="8" owner="0" type="0" pos="-60 56 -7" rot="1 0 0 0" scale="" transform="1 0 0 -60 0 1 0 56 0 0 1 -7 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 8 10" />
                            <Vertex pos="2 8 -10" />
                            <Vertex pos="2 -8 10" />
                            <Vertex pos="2 -8 -10" />
                            <Vertex pos="-2 8 10" />
                            <Vertex pos="-2 8 -10" />
                            <Vertex pos="-2 -8 10" />
                            <Vertex pos="-2 -8 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -10" album="" material="bm_tile03_A" texgens="1 0 0 0 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="9" owner="0" type="0" pos="24 10 -3" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 10 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 8 14" />
                            <Vertex pos="4 8 -14" />
                            <Vertex pos="4 -8 14" />
                            <Vertex pos="4 -8 -14" />
                            <Vertex pos="-4 8 14" />
                            <Vertex pos="-4 8 -14" />
                            <Vertex pos="-4 -8 14" />
                            <Vertex pos="-4 -8 -14" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -14" album="" material="bm_tile03_A" texgens="1 0 0 -512 0 -1 0 3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="11" owner="0" type="0" pos="24 -30 4" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 -30 0 0 1 4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 8 21" />
                            <Vertex pos="4 8 -21" />
                            <Vertex pos="4 -8 21" />
                            <Vertex pos="4 -8 -21" />
                            <Vertex pos="-4 8 21" />
                            <Vertex pos="-4 8 -21" />
                            <Vertex pos="-4 -8 21" />
                            <Vertex pos="-4 -8 -21" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -1280 0 0 -1 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 1280 0 0 -1 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -21" album="" material="bm_tile03_A" texgens="1 0 0 -512 0 -1 0 3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -21" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="12" owner="0" type="0" pos="14 -34 4" rot="1 0 0 0" scale="" transform="1 0 0 14 0 1 0 -34 0 0 1 4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 4 21" />
                            <Vertex pos="6 4 -21" />
                            <Vertex pos="6 -4 21" />
                            <Vertex pos="6 -4 -21" />
                            <Vertex pos="-6 4 21" />
                            <Vertex pos="-6 4 -21" />
                            <Vertex pos="-6 -4 21" />
                            <Vertex pos="-6 -4 -21" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 -1792 0 0 -1 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 1792 0 0 -1 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -21" album="" material="bm_tile03_A" texgens="1 0 0 0 0 -1 0 4096 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -21" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="13" owner="0" type="0" pos="0 -34 -2" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -34 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8 4 15" />
                            <Vertex pos="8 4 -15" />
                            <Vertex pos="8 -4 15" />
                            <Vertex pos="8 -4 -15" />
                            <Vertex pos="-8 4 15" />
                            <Vertex pos="-8 4 -15" />
                            <Vertex pos="-8 -4 15" />
                            <Vertex pos="-8 -4 -15" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -8" album="" material="bm_grid_blank4" texgens="0 1 0 -1792 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -8" album="" material="bm_grid_blank4" texgens="0 -1 0 1792 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 256 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -15" album="" material="bm_stripe_caution2" texgens="1 1 0 1536 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="14" owner="0" type="0" pos="-16 -34 11" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 -34 0 0 1 11 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8 4 28" />
                            <Vertex pos="8 4 -28" />
                            <Vertex pos="8 -4 28" />
                            <Vertex pos="8 -4 -28" />
                            <Vertex pos="-8 4 28" />
                            <Vertex pos="-8 4 -28" />
                            <Vertex pos="-8 -4 28" />
                            <Vertex pos="-8 -4 -28" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -8" album="" material="bm_grid_blank4" texgens="0 1 0 -1792 0 0 -1 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -8" album="" material="bm_grid_blank4" texgens="0 -1 0 1792 0 0 -1 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -3328 0 0 -1 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 3328 0 0 -1 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -28" album="" material="bm_tile03_A" texgens="1 0 0 6656 0 -1 0 4096 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -28" album="" material="bm_grid_blank4" texgens="-1 0 0 -3328 0 -1 0 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="15" owner="0" type="0" pos="-12 -31 41" rot="1 0 0 0" scale="" transform="1 0 0 -12 0 1 0 -31 0 0 1 41 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 1 2" />
                            <Vertex pos="4 1 -2" />
                            <Vertex pos="4 -1 2" />
                            <Vertex pos="4 -1 -2" />
                            <Vertex pos="-4 1 2" />
                            <Vertex pos="-4 1 -2" />
                            <Vertex pos="-4 -1 2" />
                            <Vertex pos="-4 -1 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -1408 0 0 -1 -4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 1408 0 0 -1 -4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 -4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 -4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_tile03_A" texgens="1 0 0 -512 0 -1 0 3328 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="16" owner="0" type="0" pos="-12 -37 41" rot="1 0 0 0" scale="" transform="1 0 0 -12 0 1 0 -37 0 0 1 41 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 1 2" />
                            <Vertex pos="4 1 -2" />
                            <Vertex pos="4 -1 2" />
                            <Vertex pos="4 -1 -2" />
                            <Vertex pos="-4 1 2" />
                            <Vertex pos="-4 1 -2" />
                            <Vertex pos="-4 -1 2" />
                            <Vertex pos="-4 -1 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -1408 0 0 -1 -4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 1408 0 0 -1 -4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 -4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 -4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_tile03_A" texgens="1 0 0 -512 0 -1 0 3328 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="17" owner="0" type="0" pos="-12 -34 45" rot="1 0 0 0" scale="" transform="1 0 0 -12 0 1 0 -34 0 0 1 45 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 2" />
                            <Vertex pos="4 4 -2" />
                            <Vertex pos="4 -4 2" />
                            <Vertex pos="4 -4 -2" />
                            <Vertex pos="-4 4 2" />
                            <Vertex pos="-4 4 -2" />
                            <Vertex pos="-4 -4 2" />
                            <Vertex pos="-4 -4 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -1024 0 0 -1 -4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 1024 0 0 -1 -4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 -4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 -4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_tile03_A" texgens="1 0 0 -512 0 -1 0 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="18" owner="0" type="0" pos="-49 -34 12" rot="1 0 0 0" scale="" transform="1 0 0 -49 0 1 0 -34 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 4 27" />
                            <Vertex pos="1 4 -29" />
                            <Vertex pos="1 -4 27" />
                            <Vertex pos="1 -4 -29" />
                            <Vertex pos="-1 4 29" />
                            <Vertex pos="-1 4 -29" />
                            <Vertex pos="-1 -4 29" />
                            <Vertex pos="-1 -4 -29" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -1024 0 0 -1 -1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 1024 0 0 -1 -1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 0 -1 -1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -640 0 0 -1 -1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -19.799" album="" material="bm_friction_bounce_med" texgens="1 0 0 -1280 0 -1 0 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -29" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 -1 0 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="19" owner="0" type="0" pos="-20 -34 45" rot="1 0 0 0" scale="" transform="1 0 0 -20 0 1 0 -34 0 0 1 45 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 2" />
                            <Vertex pos="4 4 -2" />
                            <Vertex pos="4 -4 2" />
                            <Vertex pos="4 -4 -2" />
                            <Vertex pos="-4 4 2" />
                            <Vertex pos="-4 4 3.8147e-006" />
                            <Vertex pos="-4 -4 2" />
                            <Vertex pos="-4 -4 3.8147e-006" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -1024 0 0 -1 -4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 1024 0 0 -1 -4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 -4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 -4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_tile03_A" texgens="1 0 0 -512 0 -1 0 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.970139" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="20" owner="0" type="0" pos="-52 -34 17" rot="1 0 0 0" scale="" transform="1 0 0 -52 0 1 0 -34 0 0 1 17 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 34" />
                            <Vertex pos="2 4 -34" />
                            <Vertex pos="2 -4 34" />
                            <Vertex pos="2 -4 -34" />
                            <Vertex pos="-2 4 34" />
                            <Vertex pos="-2 4 -34" />
                            <Vertex pos="-2 -4 34" />
                            <Vertex pos="-2 -4 -34" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -1024 0 0 -1 -6144 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 1024 0 0 -1 -6144 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 0 -1 -6144 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -512 0 0 -1 -6144 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -34" album="" material="bm_tile03_A" texgens="1 0 0 -1024 0 -1 0 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -34" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 -1 0 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="21" owner="0" type="0" pos="-12 -46 15" rot="1 0 0 0" scale="" transform="1 0 0 -12 0 1 0 -46 0 0 1 15 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 8 32" />
                            <Vertex pos="4 8 -32" />
                            <Vertex pos="4 -8 32" />
                            <Vertex pos="4 -8 -32" />
                            <Vertex pos="-4 8 32" />
                            <Vertex pos="-4 8 -32" />
                            <Vertex pos="-4 -8 32" />
                            <Vertex pos="-4 -8 -32" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -1536 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 1536 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -32" album="" material="bm_tile03_A" texgens="1 0 0 -512 0 -1 0 3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -32" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="22" owner="0" type="0" pos="-12 -27 19" rot="1 0 0 0" scale="" transform="1 0 0 -12 0 1 0 -27 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 3 36" />
                            <Vertex pos="4 3 -36" />
                            <Vertex pos="4 -3 36" />
                            <Vertex pos="4 -3 -36" />
                            <Vertex pos="-4 3 36" />
                            <Vertex pos="-4 3 -36" />
                            <Vertex pos="-4 -3 36" />
                            <Vertex pos="-4 -3 -36" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -2176 0 0 -1 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 2176 0 0 -1 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -36" album="" material="bm_tile03_A" texgens="1 0 0 -512 0 -1 0 4864 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -36" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="23" owner="0" type="0" pos="-12 -36 69" rot="1 0 0 0" scale="" transform="1 0 0 -12 0 1 0 -36 0 0 1 69 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 12" />
                            <Vertex pos="4 4 -12" />
                            <Vertex pos="4 -4 12" />
                            <Vertex pos="4 -4 -12" />
                            <Vertex pos="-4 4 12" />
                            <Vertex pos="-4 4 -12" />
                            <Vertex pos="-4 -4 12" />
                            <Vertex pos="-4 -4 -12" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -1024 0 0 -1 -5888 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 1024 0 0 -1 -5888 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 -5888 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 -5888 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -12" album="" material="bm_tile03_A" texgens="1 0 0 -512 0 -1 0 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -12" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="24" owner="0" type="0" pos="-18 -27 23" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 -27 0 0 1 23 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 3 40" />
                            <Vertex pos="2 3 -40" />
                            <Vertex pos="2 -3 40" />
                            <Vertex pos="2 -3 -40" />
                            <Vertex pos="-2 3 40" />
                            <Vertex pos="-2 3 -40" />
                            <Vertex pos="-2 -3 40" />
                            <Vertex pos="-2 -3 -40" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -1152 0 0 -1 -6912 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 1152 0 0 -1 -6912 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 -6912 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 -6912 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -40" album="" material="bm_tile03_A" texgens="1 0 0 0 0 -1 0 2816 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -40" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="25" owner="0" type="0" pos="-18 -36 59" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 -36 0 0 1 59 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 6 4" />
                            <Vertex pos="2 6 -4" />
                            <Vertex pos="2 -4 4" />
                            <Vertex pos="2 -6 -4" />
                            <Vertex pos="-2 6 4" />
                            <Vertex pos="-2 6 -4" />
                            <Vertex pos="-2 -4 4" />
                            <Vertex pos="-2 -6 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 -1 -4864 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 -4864 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 -4864 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.970143 0.242536 -4.85072" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 -4864 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_tile03_A" texgens="1 0 0 0 0 -1 0 2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="26" owner="0" type="0" pos="-6 -36 59" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 -36 0 0 1 59 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 6 4" />
                            <Vertex pos="2 6 -4" />
                            <Vertex pos="2 -4 4" />
                            <Vertex pos="2 -6 -4" />
                            <Vertex pos="-2 6 4" />
                            <Vertex pos="-2 6 -4" />
                            <Vertex pos="-2 -4 4" />
                            <Vertex pos="-2 -6 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 -1 -4864 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 -4864 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 -4864 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.970143 0.242536 -4.85072" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 -4864 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_tile03_A" texgens="1 0 0 0 0 -1 0 2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="27" owner="0" type="0" pos="-6 -27 23" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 -27 0 0 1 23 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 3 40" />
                            <Vertex pos="2 3 -40" />
                            <Vertex pos="2 -3 40" />
                            <Vertex pos="2 -3 -40" />
                            <Vertex pos="-2 3 40" />
                            <Vertex pos="-2 3 -40" />
                            <Vertex pos="-2 -3 40" />
                            <Vertex pos="-2 -3 -40" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -1152 0 0 -1 -6912 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 1152 0 0 -1 -6912 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 -6912 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 -6912 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -40" album="" material="bm_tile03_A" texgens="1 0 0 0 0 -1 0 2816 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -40" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="28" owner="0" type="0" pos="-18 -32 72" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 -32 0 0 1 72 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 8 9" />
                            <Vertex pos="2 8 -9" />
                            <Vertex pos="2 -8 9" />
                            <Vertex pos="2 -8 -9" />
                            <Vertex pos="-2 8 9" />
                            <Vertex pos="-2 8 -9" />
                            <Vertex pos="-2 -8 9" />
                            <Vertex pos="-2 -8 -9" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -1280 0 0 -1 -6016 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 1280 0 0 -1 -6016 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 -6016 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 -6016 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -9" album="" material="bm_tile03_A" texgens="1 0 0 0 0 -1 0 3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -9" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="29" owner="0" type="0" pos="-6 -32 72" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 -32 0 0 1 72 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 8 9" />
                            <Vertex pos="2 8 -9" />
                            <Vertex pos="2 -8 9" />
                            <Vertex pos="2 -8 -9" />
                            <Vertex pos="-2 8 9" />
                            <Vertex pos="-2 8 -9" />
                            <Vertex pos="-2 -8 9" />
                            <Vertex pos="-2 -8 -9" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -1280 0 0 -1 -6016 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 1280 0 0 -1 -6016 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 -6016 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 -6016 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -9" album="" material="bm_tile03_A" texgens="1 0 0 0 0 -1 0 3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -9" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="30" owner="0" type="0" pos="-12 -67 57" rot="1 0 0 0" scale="" transform="1 0 0 -12 0 1 0 -67 0 0 1 57 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 1 4" />
                            <Vertex pos="4 1 -4" />
                            <Vertex pos="4 -1 4" />
                            <Vertex pos="4 -1 -4" />
                            <Vertex pos="-4 1 4" />
                            <Vertex pos="-4 1 -4" />
                            <Vertex pos="-4 -1 4" />
                            <Vertex pos="-4 -1 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -640 0 0 -1 -4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 640 0 0 -1 -4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_tile03_A" texgens="-1 0 0 -512 0 0 -1 -2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 -4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="31" owner="0" type="0" pos="-12 -22 32" rot="1 0 0 0" scale="" transform="1 0 0 -12 0 1 0 -22 0 0 1 32 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8 2 49" />
                            <Vertex pos="8 2 -49" />
                            <Vertex pos="8 -2 49" />
                            <Vertex pos="8 -2 -49" />
                            <Vertex pos="-8 2 49" />
                            <Vertex pos="-8 2 -49" />
                            <Vertex pos="-8 -2 49" />
                            <Vertex pos="-8 -2 -49" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -8" album="" material="bm_grid_blank4" texgens="0 1 0 -2048 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -8" album="" material="bm_grid_blank4" texgens="0 -1 0 2048 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 256 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -49" album="" material="bm_tile03_A" texgens="1 0 0 512 0 -1 0 4608 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -49" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="32" owner="0" type="0" pos="-1 -2.25 0.75" rot="1 0 0 0" scale="" transform="1 0 0 -1 0 1 0 -2.25 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.5 0.25 0.25" />
                            <Vertex pos="3.5 0.25 -0.25" />
                            <Vertex pos="3.5 -0.25 0.25" />
                            <Vertex pos="3.5 -0.25 -0.25" />
                            <Vertex pos="-3.5 0.25 0.25" />
                            <Vertex pos="-3.5 0.25 -0.25" />
                            <Vertex pos="-3.5 -0.25 0.25" />
                            <Vertex pos="-3.5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3.5" album="" material="bm_edge_white" texgens="0 1 0 3136 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3.5" album="" material="bm_edge_white" texgens="0 -1 0 -3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -768 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 896 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="33" owner="0" type="0" pos="-8 48.25 10.75" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 48.25 0 0 1 10.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8 0.25 0.25" />
                            <Vertex pos="8 0.25 -0.25" />
                            <Vertex pos="8 -0.25 0.25" />
                            <Vertex pos="8 -0.25 -0.25" />
                            <Vertex pos="-8 0.25 0.25" />
                            <Vertex pos="-8 0.25 -0.25" />
                            <Vertex pos="-8 -0.25 0.25" />
                            <Vertex pos="-8 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -8" album="" material="bm_edge_white" texgens="0 1 0 3136 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -8" album="" material="bm_edge_white" texgens="0 -1 0 -3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2048 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1920 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2048 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="34" owner="0" type="0" pos="-11 41.75 10.75" rot="1 0 0 0" scale="" transform="1 0 0 -11 0 1 0 41.75 0 0 1 10.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.25 0.25" />
                            <Vertex pos="5 0.25 -0.25" />
                            <Vertex pos="5 -0.25 0.25" />
                            <Vertex pos="5 -0.25 -0.25" />
                            <Vertex pos="-5 0.25 0.25" />
                            <Vertex pos="-5 0.25 -0.25" />
                            <Vertex pos="-5 -0.25 0.25" />
                            <Vertex pos="-5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_edge_white" texgens="0 1 0 3136 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="" material="bm_edge_white" texgens="0 -1 0 -3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1792 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1664 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1792 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="35" owner="0" type="0" pos="-16.125 45 10.75" rot="1 0 0 0" scale="" transform="1 0 0 -16.125 0 1 0 45 0 0 1 10.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 3.5 0.25" />
                            <Vertex pos="0.125 3.5 -0.25" />
                            <Vertex pos="0.125 -3.5 0.25" />
                            <Vertex pos="0.125 -3.5 -0.25" />
                            <Vertex pos="-0.125 3.5 0.25" />
                            <Vertex pos="-0.125 3.5 -0.25" />
                            <Vertex pos="-0.125 -3.5 0.25" />
                            <Vertex pos="-0.125 -3.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_trim" texgens="0 1 0 11520 0 0 -1 -2752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_trim" texgens="0 -1 0 -11520 0 0 -1 -2752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3.5" album="" material="bm_trim" texgens="-1 0 0 4128 0 0 -1 -2752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3.5" album="" material="bm_trim" texgens="1 0 0 -4128 0 0 -1 -2752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_trim" texgens="1 0 0 -4128 0 -1 0 -11520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_trim" texgens="-1 0 0 4128 0 -1 0 -11520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="36" owner="0" type="0" pos="-50 43.75 0.75" rot="1 0 0 0" scale="" transform="1 0 0 -50 0 1 0 43.75 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.25 0.25" />
                            <Vertex pos="4 0.25 -0.25" />
                            <Vertex pos="4 -0.25 0.25" />
                            <Vertex pos="4 -0.25 -0.25" />
                            <Vertex pos="-4 0.25 0.25" />
                            <Vertex pos="-4 0.25 -0.25" />
                            <Vertex pos="-4 -0.25 0.25" />
                            <Vertex pos="-4 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 3136 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 -3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2048 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1920 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2048 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="37" owner="0" type="0" pos="-52 56.25 0.75" rot="1 0 0 0" scale="" transform="1 0 0 -52 0 1 0 56.25 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.25 0.25" />
                            <Vertex pos="6 0.25 -0.25" />
                            <Vertex pos="6 -0.25 0.25" />
                            <Vertex pos="6 -0.25 -0.25" />
                            <Vertex pos="-6 0.25 0.25" />
                            <Vertex pos="-6 0.25 -0.25" />
                            <Vertex pos="-6 -0.25 0.25" />
                            <Vertex pos="-6 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 3136 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 -3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2560 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2432 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2432 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2560 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="38" owner="0" type="0" pos="-45.875 50 0.75" rot="1 0 0 0" scale="" transform="1 0 0 -45.875 0 1 0 50 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 6.5 0.25" />
                            <Vertex pos="0.125 6.5 -0.25" />
                            <Vertex pos="0.125 -6.5 0.25" />
                            <Vertex pos="0.125 -6.5 -0.25" />
                            <Vertex pos="-0.125 6.5 0.25" />
                            <Vertex pos="-0.125 6.5 -0.25" />
                            <Vertex pos="-0.125 -6.5 0.25" />
                            <Vertex pos="-0.125 -6.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_trim" texgens="0 1 0 12800 0 0 -1 -192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_trim" texgens="0 -1 0 -12800 0 0 -1 -192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6.5" album="" material="bm_trim" texgens="-1 0 0 11744 0 0 -1 -192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6.5" album="" material="bm_trim" texgens="1 0 0 -11744 0 0 -1 -192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_trim" texgens="1 0 0 -11744 0 -1 0 -12800 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_trim" texgens="-1 0 0 11744 0 -1 0 -12800 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="39" owner="0" type="0" pos="-62.25 56.25 2.75" rot="1 0 0 0" scale="" transform="1 0 0 -62.25 0 1 0 56.25 0 0 1 2.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 8.25 0.25" />
                            <Vertex pos="0.25 8.25 -0.25" />
                            <Vertex pos="0.25 -8.25 0.25" />
                            <Vertex pos="0.25 -8.25 -0.25" />
                            <Vertex pos="-0.25 8.25 0.25" />
                            <Vertex pos="-0.25 8.25 -0.25" />
                            <Vertex pos="-0.25 -8.25 0.25" />
                            <Vertex pos="-0.25 -8.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2112 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1984 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="40" owner="0" type="0" pos="-57.75 60.25 2.75" rot="1 0 0 0" scale="" transform="1 0 0 -57.75 0 1 0 60.25 0 0 1 2.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4.25 0.25" />
                            <Vertex pos="0.25 4.25 -0.25" />
                            <Vertex pos="0.25 -4.25 0.25" />
                            <Vertex pos="0.25 -4.25 -0.25" />
                            <Vertex pos="-0.25 4.25 0.25" />
                            <Vertex pos="-0.25 4.25 -0.25" />
                            <Vertex pos="-0.25 -4.25 0.25" />
                            <Vertex pos="-0.25 -4.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 1088 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -960 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="41" owner="0" type="0" pos="-60 64.25 5.25" rot="1 0 0 0" scale="" transform="1 0 0 -60 0 1 0 64.25 0 0 1 5.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.5 0.25 0.25" />
                            <Vertex pos="2.5 0.25 -0.25" />
                            <Vertex pos="2.5 -0.25 0.25" />
                            <Vertex pos="2.5 -0.25 -0.25" />
                            <Vertex pos="-2.5 0.25 0.25" />
                            <Vertex pos="-2.5 0.25 -0.25" />
                            <Vertex pos="-2.5 -0.25 0.25" />
                            <Vertex pos="-2.5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2.5" album="" material="bm_edge_white" texgens="0 1 0 3136 0 0 -1 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.5" album="" material="bm_edge_white" texgens="0 -1 0 -3008 0 0 -1 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -512 0 0 -1 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -512 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 640 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="42" owner="0" type="0" pos="-57.75 56.25 1.75" rot="1 0 0 0" scale="" transform="1 0 0 -57.75 0 1 0 56.25 0 0 1 1.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 0.75" />
                            <Vertex pos="0.25 0.25 -0.75" />
                            <Vertex pos="0.25 -0.25 0.75" />
                            <Vertex pos="0.25 -0.25 -0.75" />
                            <Vertex pos="-0.25 0.25 0.75" />
                            <Vertex pos="-0.25 0.25 -0.75" />
                            <Vertex pos="-0.25 -0.25 0.75" />
                            <Vertex pos="-0.25 -0.25 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3136 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -3008 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1216 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1088 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.75" album="" material="bm_edge_white" texgens="1 0 0 -1088 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.75" album="" material="bm_edge_white" texgens="-1 0 0 1216 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="43" owner="0" type="0" pos="-62.25 40 6.75" rot="1 0 0 0" scale="" transform="1 0 0 -62.25 0 1 0 40 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 8 0.25" />
                            <Vertex pos="0.25 8 -0.25" />
                            <Vertex pos="0.25 -8 0.25" />
                            <Vertex pos="0.25 -8 -0.25" />
                            <Vertex pos="-0.25 8 0.25" />
                            <Vertex pos="-0.25 8 -0.25" />
                            <Vertex pos="-0.25 -8 0.25" />
                            <Vertex pos="-0.25 -8 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2048 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -1920 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -1920 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="44" owner="0" type="0" pos="-62.25 47.75 4.5" rot="1 0 0 0" scale="" transform="1 0 0 -62.25 0 1 0 47.75 0 0 1 4.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 2" />
                            <Vertex pos="0.25 0.25 -2" />
                            <Vertex pos="0.25 -0.25 2" />
                            <Vertex pos="0.25 -0.25 -2" />
                            <Vertex pos="-0.25 0.25 2" />
                            <Vertex pos="-0.25 0.25 -2" />
                            <Vertex pos="-0.25 -0.25 2" />
                            <Vertex pos="-0.25 -0.25 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3136 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -3008 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1216 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1088 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_edge_white" texgens="1 0 0 -1088 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_edge_white" texgens="-1 0 0 1216 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="45" owner="0" type="0" pos="-53.75 40 6.75" rot="1 0 0 0" scale="" transform="1 0 0 -53.75 0 1 0 40 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 7.5 0.25" />
                            <Vertex pos="0.25 7.5 -0.25" />
                            <Vertex pos="0.25 -8 0.25" />
                            <Vertex pos="0.25 -8 -0.25" />
                            <Vertex pos="-0.25 8 0.25" />
                            <Vertex pos="-0.25 8 -0.25" />
                            <Vertex pos="-0.25 -8 0.25" />
                            <Vertex pos="-0.25 -8 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2048 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -5.48008" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-2.98023e-008 -2.98023e-008 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -1920 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -1920 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="46" owner="0" type="0" pos="19.75 10 10.75" rot="1 0 0 0" scale="" transform="1 0 0 19.75 0 1 0 10 0 0 1 10.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 8 0.25" />
                            <Vertex pos="0.25 8 -0.25" />
                            <Vertex pos="0.25 -8 0.25" />
                            <Vertex pos="0.25 -8 -0.25" />
                            <Vertex pos="-0.25 7.5 0.25" />
                            <Vertex pos="-0.25 7.5 -0.25" />
                            <Vertex pos="-0.25 -8 0.25" />
                            <Vertex pos="-0.25 -8 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2048 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1920.01 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -5.48008" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -1920.01 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -1920.01 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="47" owner="0" type="0" pos="28.25 10 10.75" rot="1 0 0 0" scale="" transform="1 0 0 28.25 0 1 0 10 0 0 1 10.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 8 0.25" />
                            <Vertex pos="0.25 8 -0.25" />
                            <Vertex pos="0.25 -8 0.25" />
                            <Vertex pos="0.25 -8 -0.25" />
                            <Vertex pos="-0.25 8 0.25" />
                            <Vertex pos="-0.25 8 -0.25" />
                            <Vertex pos="-0.25 -8 0.25" />
                            <Vertex pos="-0.25 -8 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2048 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -1920 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -1920 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="48" owner="0" type="0" pos="24 1.875 10.75" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 1.875 0 0 1 10.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.5 0.125 0.25" />
                            <Vertex pos="4.5 0.125 -0.25" />
                            <Vertex pos="4.5 -0.125 0.25" />
                            <Vertex pos="4.5 -0.125 -0.25" />
                            <Vertex pos="-4.5 0.125 0.25" />
                            <Vertex pos="-4.5 0.125 -0.25" />
                            <Vertex pos="-4.5 -0.125 0.25" />
                            <Vertex pos="-4.5 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4.5" album="" material="bm_trim" texgens="0 1 0 480 0 0 -1 -2752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4.5" album="" material="bm_trim" texgens="0 -1 0 -480 0 0 -1 -2752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_trim" texgens="-1 0 0 -6144 0 0 -1 -2752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_trim" texgens="1 0 0 6144 0 0 -1 -2752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_trim" texgens="1 0 0 6144 0 -1 0 -480 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_trim" texgens="-1 0 0 -6144 0 -1 0 -480 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="53" owner="0" type="0" pos="24 -21.875 24.75" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 -21.875 0 0 1 24.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.5 0.125 0.25" />
                            <Vertex pos="4.5 0.125 -0.25" />
                            <Vertex pos="4.5 -0.125 0.25" />
                            <Vertex pos="4.5 -0.125 -0.25" />
                            <Vertex pos="-4.5 0.125 0.25" />
                            <Vertex pos="-4.5 0.125 -0.25" />
                            <Vertex pos="-4.5 -0.125 0.25" />
                            <Vertex pos="-4.5 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4.5" album="" material="bm_trim" texgens="0 1 0 -5600 0 0 -1 -6336 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4.5" album="" material="bm_trim" texgens="0 -1 0 5600 0 0 -1 -6336 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_trim" texgens="-1 0 0 -6144 0 0 -1 -6336 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_trim" texgens="1 0 0 6144 0 0 -1 -6336 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_trim" texgens="1 0 0 6144 0 -1 0 5600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_trim" texgens="-1 0 0 -6144 0 -1 0 5600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="54" owner="0" type="0" pos="28.25 -30.25 24.75" rot="1 0 0 0" scale="" transform="1 0 0 28.25 0 1 0 -30.25 0 0 1 24.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 8.25 0.25" />
                            <Vertex pos="0.25 8.25 -0.25" />
                            <Vertex pos="0.25 -8.25 0.25" />
                            <Vertex pos="0.25 -8.25 -0.25" />
                            <Vertex pos="-0.25 8.25 0.25" />
                            <Vertex pos="-0.25 8.25 -0.25" />
                            <Vertex pos="-0.25 -8.25 0.25" />
                            <Vertex pos="-0.25 -8.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 1984 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1856 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -1856 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -1856 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="55" owner="0" type="0" pos="19.75 -25.75 24.75" rot="1 0 0 0" scale="" transform="1 0 0 19.75 0 1 0 -25.75 0 0 1 24.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3.75 0.25" />
                            <Vertex pos="0.25 3.75 -0.25" />
                            <Vertex pos="0.25 -3.75 0.25" />
                            <Vertex pos="0.25 -3.75 -0.25" />
                            <Vertex pos="-0.25 3.75 0.25" />
                            <Vertex pos="-0.25 3.75 -0.25" />
                            <Vertex pos="-0.25 -3.75 0.25" />
                            <Vertex pos="-0.25 -3.75 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3136 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -3008 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3.75" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3.75" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="56" owner="0" type="0" pos="18 -38.25 24.75" rot="1 0 0 0" scale="" transform="1 0 0 18 0 1 0 -38.25 0 0 1 24.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="10 0.25 0.25" />
                            <Vertex pos="10 0.25 -0.25" />
                            <Vertex pos="10 -0.25 0.25" />
                            <Vertex pos="10 -0.25 -0.25" />
                            <Vertex pos="-10 0.25 0.25" />
                            <Vertex pos="-10 0.25 -0.25" />
                            <Vertex pos="-10 -0.25 0.25" />
                            <Vertex pos="-10 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -10" album="" material="bm_edge_white" texgens="0 1 0 3136 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -10" album="" material="bm_edge_white" texgens="0 -1 0 -3008 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -1280 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1408 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1408 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -1280 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="57" owner="0" type="0" pos="14 -29.75 24.75" rot="1 0 0 0" scale="" transform="1 0 0 14 0 1 0 -29.75 0 0 1 24.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.25 0.25" />
                            <Vertex pos="6 0.25 -0.25" />
                            <Vertex pos="6 -0.25 0.25" />
                            <Vertex pos="6 -0.25 -0.25" />
                            <Vertex pos="-6 0.25 0.25" />
                            <Vertex pos="-6 0.25 -0.25" />
                            <Vertex pos="-6 -0.25 0.25" />
                            <Vertex pos="-6 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 3136 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 -3008 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -256 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 384 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 384 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -256 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="58" owner="0" type="0" pos="2 -29.75 12.75" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 -29.75 0 0 1 12.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.25 0.25" />
                            <Vertex pos="6 0.25 -0.25" />
                            <Vertex pos="6 -0.25 0.25" />
                            <Vertex pos="6 -0.25 -0.25" />
                            <Vertex pos="-6 0.25 0.25" />
                            <Vertex pos="-6 0.25 -0.25" />
                            <Vertex pos="-6 -0.25 0.25" />
                            <Vertex pos="-6 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 3136 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 -3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 384 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -256 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="59" owner="0" type="0" pos="0 -38.25 12.75" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -38.25 0 0 1 12.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8 0.25 0.25" />
                            <Vertex pos="8 0.25 -0.25" />
                            <Vertex pos="8 -0.25 0.25" />
                            <Vertex pos="8 -0.25 -0.25" />
                            <Vertex pos="-8 0.25 0.25" />
                            <Vertex pos="-8 0.25 -0.25" />
                            <Vertex pos="-8 -0.25 0.25" />
                            <Vertex pos="-8 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -8" album="" material="bm_edge_white" texgens="0 1 0 3136 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -8" album="" material="bm_edge_white" texgens="0 -1 0 -3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 896 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -768 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="60" owner="0" type="0" pos="8.25 -38.25 18.5" rot="1 0 0 0" scale="" transform="1 0 0 8.25 0 1 0 -38.25 0 0 1 18.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 6" />
                            <Vertex pos="0.25 0.25 -6" />
                            <Vertex pos="0.25 -0.25 6" />
                            <Vertex pos="0.25 -0.25 -6" />
                            <Vertex pos="-0.25 0.25 6" />
                            <Vertex pos="-0.25 0.25 -6" />
                            <Vertex pos="-0.25 -0.25 6" />
                            <Vertex pos="-0.25 -0.25 -6" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3136 0 0 -1 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -3008 0 0 -1 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1216 0 0 -1 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1088 0 0 -1 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6" album="" material="bm_edge_white" texgens="1 0 0 -1088 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -6" album="" material="bm_edge_white" texgens="-1 0 0 1216 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="61" owner="0" type="0" pos="8.25 -29.75 18.5" rot="1 0 0 0" scale="" transform="1 0 0 8.25 0 1 0 -29.75 0 0 1 18.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 6" />
                            <Vertex pos="0.25 0.25 -6" />
                            <Vertex pos="0.25 -0.25 6" />
                            <Vertex pos="0.25 -0.25 -6" />
                            <Vertex pos="-0.25 0.25 6" />
                            <Vertex pos="-0.25 0.25 -6" />
                            <Vertex pos="-0.25 -0.25 6" />
                            <Vertex pos="-0.25 -0.25 -6" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3136 0 0 -1 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -3008 0 0 -1 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1216 0 0 -1 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1088 0 0 -1 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6" album="" material="bm_edge_white" texgens="1 0 0 -1088 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -6" album="" material="bm_edge_white" texgens="-1 0 0 1216 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="62" owner="0" type="0" pos="-32 -38.25 38.75" rot="1 0 0 0" scale="" transform="1 0 0 -32 0 1 0 -38.25 0 0 1 38.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="16 0.25 0.25" />
                            <Vertex pos="16 0.25 -0.25" />
                            <Vertex pos="16 -0.25 0.25" />
                            <Vertex pos="16 -0.25 -0.25" />
                            <Vertex pos="-16 0.25 0.25" />
                            <Vertex pos="-16 0.25 -0.25" />
                            <Vertex pos="-16 -0.25 0.25" />
                            <Vertex pos="-16 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -16" album="" material="bm_edge_white" texgens="0 1 0 3136 0 0 -1 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -16" album="" material="bm_edge_white" texgens="0 -1 0 -3008 0 0 -1 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -2816 0 0 -1 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 2944 0 0 -1 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 2944 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -2816 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="63" owner="0" type="0" pos="-34 -29.75 38.75" rot="1 0 0 0" scale="" transform="1 0 0 -34 0 1 0 -29.75 0 0 1 38.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="14 0.25 0.25" />
                            <Vertex pos="14 0.25 -0.25" />
                            <Vertex pos="14 -0.25 0.25" />
                            <Vertex pos="14 -0.25 -0.25" />
                            <Vertex pos="-14 0.25 0.25" />
                            <Vertex pos="-14 0.25 -0.25" />
                            <Vertex pos="-14 -0.25 0.25" />
                            <Vertex pos="-14 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -14" album="" material="bm_edge_white" texgens="0 1 0 3136 0 0 -1 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -14" album="" material="bm_edge_white" texgens="0 -1 0 -3008 0 0 -1 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -2304 0 0 -1 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 2432 0 0 -1 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 2432 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -2304 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="64" owner="0" type="0" pos="-49 -29.75 39.75" rot="1 0 0 0" scale="" transform="1 0 0 -49 0 1 0 -29.75 0 0 1 39.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 -0.75" />
                            <Vertex pos="1 0.25 -1.25" />
                            <Vertex pos="1 -0.25 -0.75" />
                            <Vertex pos="1 -0.25 -1.25" />
                            <Vertex pos="-1 0.25 1.25" />
                            <Vertex pos="-1 0.25 0.75" />
                            <Vertex pos="-1 -0.25 1.25" />
                            <Vertex pos="-1 -0.25 0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 3136 0 0 -1 -3264 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 -3008 0 0 -1 -3264 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -128 -1 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -896 0 0 -1 -3264 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -896 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 0 -0.707107 -0.176777" album="" material="bm_edge_white" texgens="-1 0 0 1024 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="65" owner="0" type="0" pos="-49 -38.25 39.75" rot="1 0 0 0" scale="" transform="1 0 0 -49 0 1 0 -38.25 0 0 1 39.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 -0.75" />
                            <Vertex pos="1 0.25 -1.25" />
                            <Vertex pos="1 -0.25 -0.75" />
                            <Vertex pos="1 -0.25 -1.25" />
                            <Vertex pos="-1 0.25 1.25" />
                            <Vertex pos="-1 0.25 0.75" />
                            <Vertex pos="-1 -0.25 1.25" />
                            <Vertex pos="-1 -0.25 0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 3136 0 0 -1 -3264 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 -3008 0 0 -1 -3264 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1024 0 0 -1 -3264 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -128 -1 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -896 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 0 -0.707107 -0.176777" album="" material="bm_edge_white" texgens="-1 0 0 1024 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="66" owner="0" type="0" pos="-56 -34 49" rot="1 0 0 0" scale="" transform="1 0 0 -56 0 1 0 -34 0 0 1 49 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 2" />
                            <Vertex pos="2 4 -2" />
                            <Vertex pos="2 -4 2" />
                            <Vertex pos="2 -4 -2" />
                            <Vertex pos="-2 4 2" />
                            <Vertex pos="-2 4 0" />
                            <Vertex pos="-2 -4 2" />
                            <Vertex pos="-2 -4 0" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -1024 0 0 -1 -10240 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 1024 0 0 -1 -10240 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 0 -1 -10240 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 -1.90735e-006 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -512 0 0 -1 -10240 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_tile03_A" texgens="1 0 0 -1024 0 -1 0 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.447214 0 -0.894427 -0.894427" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 -1 0 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="67" owner="0" type="0" pos="-50.25 -29.75 45.5" rot="1 0 0 0" scale="" transform="1 0 0 -50.25 0 1 0 -29.75 0 0 1 45.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 5" />
                            <Vertex pos="0.25 0.25 -5" />
                            <Vertex pos="0.25 -0.25 5" />
                            <Vertex pos="0.25 -0.25 -5" />
                            <Vertex pos="-0.25 0.25 5" />
                            <Vertex pos="-0.25 0.25 -5" />
                            <Vertex pos="-0.25 -0.25 5" />
                            <Vertex pos="-0.25 -0.25 -5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3136 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -3008 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1216 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1088 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -5" album="" material="bm_edge_white" texgens="1 0 0 -1088 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -5" album="" material="bm_edge_white" texgens="-1 0 0 1216 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="68" owner="0" type="0" pos="-50.25 -38.25 45.5" rot="1 0 0 0" scale="" transform="1 0 0 -50.25 0 1 0 -38.25 0 0 1 45.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 5" />
                            <Vertex pos="0.25 0.25 -5" />
                            <Vertex pos="0.25 -0.25 5" />
                            <Vertex pos="0.25 -0.25 -5" />
                            <Vertex pos="-0.25 0.25 5" />
                            <Vertex pos="-0.25 0.25 -5" />
                            <Vertex pos="-0.25 -0.25 5" />
                            <Vertex pos="-0.25 -0.25 -5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3136 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -3008 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1216 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1088 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -5" album="" material="bm_edge_white" texgens="1 0 0 -1088 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -5" album="" material="bm_edge_white" texgens="-1 0 0 1216 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="69" owner="0" type="0" pos="-54 -38.25 50.75" rot="1 0 0 0" scale="" transform="1 0 0 -54 0 1 0 -38.25 0 0 1 50.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.25 0.25" />
                            <Vertex pos="4 0.25 -0.25" />
                            <Vertex pos="4 -0.25 0.25" />
                            <Vertex pos="4 -0.25 -0.25" />
                            <Vertex pos="-4 0.25 0.25" />
                            <Vertex pos="-4 0.25 -0.25" />
                            <Vertex pos="-4 -0.25 0.25" />
                            <Vertex pos="-4 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 3136 0 0 -1 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 -3008 0 0 -1 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 256 0 0 -1 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -128 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 256 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="70" owner="0" type="0" pos="-54 -29.75 50.75" rot="1 0 0 0" scale="" transform="1 0 0 -54 0 1 0 -29.75 0 0 1 50.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.25 0.25" />
                            <Vertex pos="4 0.25 -0.25" />
                            <Vertex pos="4 -0.25 0.25" />
                            <Vertex pos="4 -0.25 -0.25" />
                            <Vertex pos="-4 0.25 0.25" />
                            <Vertex pos="-4 0.25 -0.25" />
                            <Vertex pos="-4 -0.25 0.25" />
                            <Vertex pos="-4 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 3136 0 0 -1 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 -3008 0 0 -1 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 256 0 0 -1 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -128 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 256 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="71" owner="0" type="0" pos="-58.25 -34 50.75" rot="1 0 0 0" scale="" transform="1 0 0 -58.25 0 1 0 -34 0 0 1 50.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4.5 0.25" />
                            <Vertex pos="0.25 4.5 -0.25" />
                            <Vertex pos="0.25 -4.5 0.25" />
                            <Vertex pos="0.25 -4.5 -0.25" />
                            <Vertex pos="-0.25 4.5 0.25" />
                            <Vertex pos="-0.25 4.5 -0.25" />
                            <Vertex pos="-0.25 -4.5 0.25" />
                            <Vertex pos="-0.25 -4.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2048 0 0 -1 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1920 0 0 -1 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4.5" album="" material="bm_edge_white" texgens="-1 0 0 1216 0 0 -1 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4.5" album="" material="bm_edge_white" texgens="1 0 0 -1088 0 0 -1 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1088 0 -1 0 -1920 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1216 0 -1 0 -1920 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="72" owner="0" type="0" pos="-24.125 -34 46.75" rot="1 0 0 0" scale="" transform="1 0 0 -24.125 0 1 0 -34 0 0 1 46.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 4.5 0.25" />
                            <Vertex pos="0.125 4.5 -0.25" />
                            <Vertex pos="0.125 -4.5 0.25" />
                            <Vertex pos="0.125 -4.5 -0.25" />
                            <Vertex pos="-0.125 4.5 0.25" />
                            <Vertex pos="-0.125 4.5 -0.25" />
                            <Vertex pos="-0.125 -4.5 0.25" />
                            <Vertex pos="-0.125 -4.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_trim" texgens="0 1 0 -8704 0 0 -1 -11968 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_trim" texgens="0 -1 0 8704 0 0 -1 -11968 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4.5" album="" material="bm_trim" texgens="-1 0 0 6176 0 0 -1 -11968 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4.5" album="" material="bm_trim" texgens="1 0 0 -6176 0 0 -1 -11968 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_trim" texgens="1 0 0 -6176 0 -1 0 8704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_trim" texgens="-1 0 0 6176 0 -1 0 8704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="73" owner="0" type="0" pos="-22 -29.75 46.75" rot="1 0 0 0" scale="" transform="1 0 0 -22 0 1 0 -29.75 0 0 1 46.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 0.25" />
                            <Vertex pos="2 0.25 -0.25" />
                            <Vertex pos="2 -0.25 0.25" />
                            <Vertex pos="2 -0.25 -0.25" />
                            <Vertex pos="-2 0.25 0.25" />
                            <Vertex pos="-2 0.25 -0.25" />
                            <Vertex pos="-2 -0.25 0.25" />
                            <Vertex pos="-2 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 3136 0 0 -1 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -3008 0 0 -1 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -640 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 768 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="74" owner="0" type="0" pos="-22 -38.25 46.75" rot="1 0 0 0" scale="" transform="1 0 0 -22 0 1 0 -38.25 0 0 1 46.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 0.25" />
                            <Vertex pos="2 0.25 -0.25" />
                            <Vertex pos="2 -0.25 0.25" />
                            <Vertex pos="2 -0.25 -0.25" />
                            <Vertex pos="-2 0.25 0.25" />
                            <Vertex pos="-2 0.25 -0.25" />
                            <Vertex pos="-2 -0.25 0.25" />
                            <Vertex pos="-2 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 3136 0 0 -1 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -3008 0 0 -1 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -640 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 768 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="75" owner="0" type="0" pos="-16.25 -48 46.75" rot="1 0 0 0" scale="" transform="1 0 0 -16.25 0 1 0 -48 0 0 1 46.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 6 0.25" />
                            <Vertex pos="0.25 6 -0.25" />
                            <Vertex pos="0.25 -6 0.25" />
                            <Vertex pos="0.25 -6 -0.25" />
                            <Vertex pos="-0.25 6 0.25" />
                            <Vertex pos="-0.25 6 -0.25" />
                            <Vertex pos="-0.25 -6 0.25" />
                            <Vertex pos="-0.25 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 1664 0 0 -1 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1536 0 0 -1 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 1216 0 0 -1 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 -1088 0 0 -1 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1088 0 -1 0 -1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1216 0 -1 0 -1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="76" owner="0" type="0" pos="-7.75 -42 46.75" rot="1 0 0 0" scale="" transform="1 0 0 -7.75 0 1 0 -42 0 0 1 46.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 12 0.25" />
                            <Vertex pos="0.25 12 -0.25" />
                            <Vertex pos="0.25 -12 0.25" />
                            <Vertex pos="0.25 -12 -0.25" />
                            <Vertex pos="-0.25 12 0.25" />
                            <Vertex pos="-0.25 12 -0.25" />
                            <Vertex pos="-0.25 -12 0.25" />
                            <Vertex pos="-0.25 -12 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2176 0 0 -1 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2048 0 0 -1 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -12" album="" material="bm_edge_white" texgens="-1 0 0 1216 0 0 -1 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -12" album="" material="bm_edge_white" texgens="1 0 0 -1088 0 0 -1 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1088 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1216 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="77" owner="0" type="0" pos="-12 -54.125 46.75" rot="1 0 0 0" scale="" transform="1 0 0 -12 0 1 0 -54.125 0 0 1 46.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.5 0.125 0.25" />
                            <Vertex pos="4.5 0.125 -0.25" />
                            <Vertex pos="4.5 -0.125 0.25" />
                            <Vertex pos="4.5 -0.125 -0.25" />
                            <Vertex pos="-4.5 0.125 0.25" />
                            <Vertex pos="-4.5 0.125 -0.25" />
                            <Vertex pos="-4.5 -0.125 0.25" />
                            <Vertex pos="-4.5 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4.5" album="" material="bm_trim" texgens="0 1 0 -13856 0 0 -1 -11968 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4.5" album="" material="bm_trim" texgens="0 -1 0 13856 0 0 -1 -11968 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_trim" texgens="-1 0 0 3072 0 0 -1 -11968 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_trim" texgens="1 0 0 -3072 0 0 -1 -11968 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_trim" texgens="1 0 0 -3072 0 -1 0 13856 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_trim" texgens="-1 0 0 3072 0 -1 0 13856 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="78" owner="0" type="0" pos="-12 -66.25 52.75" rot="1 0 0 0" scale="" transform="1 0 0 -12 0 1 0 -66.25 0 0 1 52.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.5 0.25 0.25" />
                            <Vertex pos="4.5 0.25 -0.25" />
                            <Vertex pos="4.5 -0.25 0.25" />
                            <Vertex pos="4.5 -0.25 -0.25" />
                            <Vertex pos="-4.5 0.25 0.25" />
                            <Vertex pos="-4.5 0.25 -0.25" />
                            <Vertex pos="-4.5 -0.25 0.25" />
                            <Vertex pos="-4.5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4.5" album="" material="bm_edge_white" texgens="0 1 0 3136 0 0 -1 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4.5" album="" material="bm_edge_white" texgens="0 -1 0 -3008 0 0 -1 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1408 0 0 -1 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1280 0 0 -1 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1280 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1408 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="79" owner="0" type="0" pos="-12 -66.25 61.25" rot="1 0 0 0" scale="" transform="1 0 0 -12 0 1 0 -66.25 0 0 1 61.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.5 0.25 0.25" />
                            <Vertex pos="4.5 0.25 -0.25" />
                            <Vertex pos="4.5 -0.25 0.25" />
                            <Vertex pos="4.5 -0.25 -0.25" />
                            <Vertex pos="-4.5 0.25 0.25" />
                            <Vertex pos="-4.5 0.25 -0.25" />
                            <Vertex pos="-4.5 -0.25 0.25" />
                            <Vertex pos="-4.5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4.5" album="" material="bm_edge_white" texgens="0 1 0 3136 0 0 -1 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4.5" album="" material="bm_edge_white" texgens="0 -1 0 -3008 0 0 -1 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1408 0 0 -1 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1280 0 0 -1 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1280 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1408 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="80" owner="0" type="0" pos="-7.75 -66.25 57" rot="1 0 0 0" scale="" transform="1 0 0 -7.75 0 1 0 -66.25 0 0 1 57 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 4" />
                            <Vertex pos="0.25 0.25 -4" />
                            <Vertex pos="0.25 -0.25 4" />
                            <Vertex pos="0.25 -0.25 -4" />
                            <Vertex pos="-0.25 0.25 4" />
                            <Vertex pos="-0.25 0.25 -4" />
                            <Vertex pos="-0.25 -0.25 4" />
                            <Vertex pos="-0.25 -0.25 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3136 0 0 -1 -4480 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -3008 0 0 -1 -4480 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 320 0 0 -1 -4480 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -192 0 0 -1 -4480 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_edge_white" texgens="1 0 0 -192 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_edge_white" texgens="-1 0 0 320 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="81" owner="0" type="0" pos="-16.25 -66.25 57" rot="1 0 0 0" scale="" transform="1 0 0 -16.25 0 1 0 -66.25 0 0 1 57 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 4" />
                            <Vertex pos="0.25 0.25 -4" />
                            <Vertex pos="0.25 -0.25 4" />
                            <Vertex pos="0.25 -0.25 -4" />
                            <Vertex pos="-0.25 0.25 4" />
                            <Vertex pos="-0.25 0.25 -4" />
                            <Vertex pos="-0.25 -0.25 4" />
                            <Vertex pos="-0.25 -0.25 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3136 0 0 -1 -4480 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -3008 0 0 -1 -4480 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 320 0 0 -1 -4480 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -192 0 0 -1 -4480 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_edge_white" texgens="1 0 0 -192 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_edge_white" texgens="-1 0 0 320 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="82" owner="0" type="0" pos="-12 -42.125 54.75" rot="1 0 0 0" scale="" transform="1 0 0 -12 0 1 0 -42.125 0 0 1 54.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.125 0.25" />
                            <Vertex pos="4 0.125 -0.25" />
                            <Vertex pos="4 -0.125 0.25" />
                            <Vertex pos="4 -0.125 -0.25" />
                            <Vertex pos="-4 0.125 0.25" />
                            <Vertex pos="-4 0.125 -0.25" />
                            <Vertex pos="-4 -0.125 0.25" />
                            <Vertex pos="-4 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_trim" texgens="0 1 0 -10784 0 0 -1 -14016 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_trim" texgens="0 -1 0 10784 0 0 -1 -14016 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_trim" texgens="-1 0 0 3072 0 0 -1 -14016 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_trim" texgens="1 0 0 -3072 0 0 -1 -14016 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_trim" texgens="1 0 0 -3072 0 -1 0 10784 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_trim" texgens="-1 0 0 3072 0 -1 0 10784 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="83" owner="0" type="0" pos="-6 -40 45" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 -40 0 0 1 45 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 10" />
                            <Vertex pos="2 2 -6" />
                            <Vertex pos="2 -2 10" />
                            <Vertex pos="2 -2 -6" />
                            <Vertex pos="-2 2 10" />
                            <Vertex pos="-2 2 -10" />
                            <Vertex pos="-2 -2 10" />
                            <Vertex pos="-2 -2 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -1280 0 0 -1 -4864 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 1280 0 0 -1 -4864 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 0 -1 -4864 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -512 0 0 -1 -4864 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -10" album="" material="bm_tile03_A" texgens="1 0 0 -1024 0 -1 0 3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -5.65686" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 -1 0 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="84" owner="0" type="0" pos="-12 -36 53" rot="1 0 0 0" scale="" transform="1 0 0 -12 0 1 0 -36 0 0 1 53 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 6 2" />
                            <Vertex pos="4 6 -2" />
                            <Vertex pos="4 -6 2" />
                            <Vertex pos="4 -6 -2" />
                            <Vertex pos="-4 6 2" />
                            <Vertex pos="-4 6 -2" />
                            <Vertex pos="-4 -6 2" />
                            <Vertex pos="-4 -6 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -1536 0 0 -1 -5888 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 1536 0 0 -1 -5888 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 -5888 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 -5888 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_tile03_A" texgens="1 0 0 -512 0 -1 0 3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="85" owner="0" type="0" pos="-18 -40 49" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 -40 0 0 1 49 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 6" />
                            <Vertex pos="2 2 -6" />
                            <Vertex pos="2 -2 6" />
                            <Vertex pos="2 -2 -6" />
                            <Vertex pos="-2 2 6" />
                            <Vertex pos="-2 2 -5" />
                            <Vertex pos="-2 -2 6" />
                            <Vertex pos="-2 -2 -5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -2048 0 0 -1 -5376 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 2048 0 0 -1 -5376 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 0 -1 -5376 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -512 0 0 -1 -5376 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6" album="" material="bm_tile03_A" texgens="1 0 0 -1024 0 -1 0 4608 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -5.33578" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 -1 0 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="86" owner="0" type="0" pos="-12 -28 72" rot="1 0 0 0" scale="" transform="1 0 0 -12 0 1 0 -28 0 0 1 72 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 9" />
                            <Vertex pos="4 4 -9" />
                            <Vertex pos="4 -4 9" />
                            <Vertex pos="4 -4 -9" />
                            <Vertex pos="-4 4 9" />
                            <Vertex pos="-4 4 -9" />
                            <Vertex pos="-4 -4 9" />
                            <Vertex pos="-4 -4 -9" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -1024 0 0 -1 -6272 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 1024 0 0 -1 -6272 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 -6272 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 -6272 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -9" album="" material="bm_tile03_A" texgens="1 0 0 -512 0 -1 0 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -9" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="87" owner="0" type="0" pos="-6 -34 53" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 -34 0 0 1 53 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 2" />
                            <Vertex pos="2 4 -2" />
                            <Vertex pos="2 -4 2" />
                            <Vertex pos="2 -4 -2" />
                            <Vertex pos="-2 4 2" />
                            <Vertex pos="-2 4 -2" />
                            <Vertex pos="-2 -4 2" />
                            <Vertex pos="-2 -4 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -1792 0 0 -1 -5888 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 1792 0 0 -1 -5888 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 0 -1 -5888 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -512 0 0 -1 -5888 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_tile03_A" texgens="1 0 0 -1024 0 -1 0 4096 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 -1 0 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="88" owner="0" type="0" pos="-18 -34 53" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 -34 0 0 1 53 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 2" />
                            <Vertex pos="2 4 -2" />
                            <Vertex pos="2 -4 2" />
                            <Vertex pos="2 -4 -2" />
                            <Vertex pos="-2 4 2" />
                            <Vertex pos="-2 4 -2" />
                            <Vertex pos="-2 -4 2" />
                            <Vertex pos="-2 -4 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -1280 0 0 -1 -5888 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 1280 0 0 -1 -5888 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 -5888 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 -5888 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_tile03_A" texgens="1 0 0 0 0 -1 0 3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="89" owner="0" type="0" pos="-3 16 2" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 16 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 8 5" />
                            <Vertex pos="3 8 -5" />
                            <Vertex pos="3 -8 5" />
                            <Vertex pos="3 -8 -5" />
                            <Vertex pos="-3 8 5" />
                            <Vertex pos="-3 8 -5" />
                            <Vertex pos="-3 -8 5" />
                            <Vertex pos="-3 -8 -5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 -768 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -5" album="" material="bm_tile03_A" texgens="1 0 0 -256 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -5" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="90" owner="0" type="0" pos="1 9 4.75" rot="1 0 0 0" scale="" transform="1 0 0 1 0 1 0 9 0 0 1 4.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 2.25" />
                            <Vertex pos="1 1 -2.25" />
                            <Vertex pos="1 -1 2.25" />
                            <Vertex pos="1 -1 -1.75" />
                            <Vertex pos="-1 1 2.25" />
                            <Vertex pos="-1 1 -2.25" />
                            <Vertex pos="-1 -1 2.25" />
                            <Vertex pos="-1 -1 -1.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -128 0 0 -1 -480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 -480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 0 -1 -480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -384 0 0 -1 -480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2.25" album="" material="bm_tile03_A" texgens="1 0 0 -768 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970143 -1.94028" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="91" owner="0" type="0" pos="1 9 -0.25" rot="1 0 0 0" scale="" transform="1 0 0 1 0 1 0 9 0 0 1 -0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 0.75" />
                            <Vertex pos="1 1 -1.25" />
                            <Vertex pos="1 -1 1.25" />
                            <Vertex pos="1 -1 -0.75" />
                            <Vertex pos="-1 1 0.75" />
                            <Vertex pos="-1 1 -1.25" />
                            <Vertex pos="-1 -1 1.25" />
                            <Vertex pos="-1 -1 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -128 0 0 -1 -608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 -608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 0 -1 -608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -384 0 0 -1 -608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970143 -0.970143" album="" material="bm_tile03_A" texgens="1 0 0 -768 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970143 -0.970143" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="92" owner="0" type="0" pos="1 11 -1" rot="1 0 0 0" scale="" transform="1 0 0 1 0 1 0 11 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 0.5" />
                            <Vertex pos="1 1 -1.5" />
                            <Vertex pos="1 -1 1.5" />
                            <Vertex pos="1 -1 -0.5" />
                            <Vertex pos="-1 1 0.5" />
                            <Vertex pos="-1 1 -1.5" />
                            <Vertex pos="-1 -1 1.5" />
                            <Vertex pos="-1 -1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -128 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -384 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.447214 0.894427 -0.894427" album="" material="bm_tile03_A" texgens="1 0 0 -768 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.447214 -0.894427 -0.894427" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="93" owner="0" type="0" pos="1 13 -1.75" rot="1 0 0 0" scale="" transform="1 0 0 1 0 1 0 13 0 0 1 -1.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 0.75" />
                            <Vertex pos="1 1 -1.25" />
                            <Vertex pos="1 -1 1.25" />
                            <Vertex pos="1 -1 -0.75" />
                            <Vertex pos="-1 1 0.75" />
                            <Vertex pos="-1 1 -1.25" />
                            <Vertex pos="-1 -1 1.25" />
                            <Vertex pos="-1 -1 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -128 0 0 -1 -416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 -416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 0 -1 -416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -384 0 0 -1 -416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970143 -0.970143" album="" material="bm_tile03_A" texgens="1 0 0 -768 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970143 -0.970143" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="94" owner="0" type="0" pos="1 19 -2" rot="1 0 0 0" scale="" transform="1 0 0 1 0 1 0 19 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 5 1" />
                            <Vertex pos="1 5 -1" />
                            <Vertex pos="1 -5 1" />
                            <Vertex pos="1 -5 -1" />
                            <Vertex pos="-1 5 1" />
                            <Vertex pos="-1 5 -1" />
                            <Vertex pos="-1 -5 1" />
                            <Vertex pos="-1 -5 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 384 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 -384 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -5" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile03_A" texgens="1 0 0 256 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="95" owner="0" type="0" pos="1 15 4" rot="1 0 0 0" scale="" transform="1 0 0 1 0 1 0 15 0 0 1 4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 1" />
                            <Vertex pos="1 1 -1" />
                            <Vertex pos="1 -1 1" />
                            <Vertex pos="1 -1 -1" />
                            <Vertex pos="-1 1 1" />
                            <Vertex pos="-1 1 -1" />
                            <Vertex pos="-1 -1 1" />
                            <Vertex pos="-1 -1 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile03_A" texgens="1 0 0 256 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="96" owner="0" type="0" pos="1 18 2" rot="1 0 0 0" scale="" transform="1 0 0 1 0 1 0 18 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 4 1" />
                            <Vertex pos="1 4 -1" />
                            <Vertex pos="1 -4 1" />
                            <Vertex pos="1 -4 -1" />
                            <Vertex pos="-1 4 1" />
                            <Vertex pos="-1 4 -1" />
                            <Vertex pos="-1 -4 1" />
                            <Vertex pos="-1 -4 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile03_A" texgens="1 0 0 256 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="97" owner="0" type="0" pos="1 13 3" rot="1 0 0 0" scale="" transform="1 0 0 1 0 1 0 13 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 2" />
                            <Vertex pos="1 1 -2" />
                            <Vertex pos="1 -1 2" />
                            <Vertex pos="1 -1 -1.5" />
                            <Vertex pos="-1 1 2" />
                            <Vertex pos="-1 1 -2" />
                            <Vertex pos="-1 -1 2" />
                            <Vertex pos="-1 -1 -1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -128 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -384 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_tile03_A" texgens="1 0 0 -768 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970143 -1.69775" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="98" owner="0" type="0" pos="1 11 3.25" rot="1 0 0 0" scale="" transform="1 0 0 1 0 1 0 11 0 0 1 3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 1.75" />
                            <Vertex pos="1 1 -1.75" />
                            <Vertex pos="1 -1 1.75" />
                            <Vertex pos="1 -1 -0.75" />
                            <Vertex pos="-1 1 1.75" />
                            <Vertex pos="-1 1 -1.75" />
                            <Vertex pos="-1 -1 1.75" />
                            <Vertex pos="-1 -1 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -128 0 0 -1 -544 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 -544 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 0 -1 -544 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -384 0 0 -1 -544 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.75" album="" material="bm_tile03_A" texgens="1 0 0 -768 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.447214 -0.894427 -1.11803" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="99" owner="0" type="0" pos="-2 27 -7" rot="1 0 0 0" scale="" transform="1 0 0 -2 0 1 0 27 0 0 1 -7 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 3 10" />
                            <Vertex pos="4 3 -10" />
                            <Vertex pos="4 -3 10" />
                            <Vertex pos="4 -3 -10" />
                            <Vertex pos="-4 3 10" />
                            <Vertex pos="-4 3 -10" />
                            <Vertex pos="-4 -3 10" />
                            <Vertex pos="-4 -3 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -128 0 0 -1 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -10" album="" material="bm_tile03_A" texgens="1 0 0 0 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="100" owner="0" type="0" pos="-2 27 8" rot="1 0 0 0" scale="" transform="1 0 0 -2 0 1 0 27 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 3 3" />
                            <Vertex pos="4 3 -3" />
                            <Vertex pos="4 -3 3" />
                            <Vertex pos="4 -3 -3" />
                            <Vertex pos="-4 3 3" />
                            <Vertex pos="-4 3 -3" />
                            <Vertex pos="-4 -3 3" />
                            <Vertex pos="-4 -3 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -128 0 0 -1 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_tile03_A" texgens="1 0 0 0 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="101" owner="0" type="0" pos="-2 27 4" rot="1 0 0 0" scale="" transform="1 0 0 -2 0 1 0 27 0 0 1 4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 3 1" />
                            <Vertex pos="4 3 -1" />
                            <Vertex pos="4 -3 1" />
                            <Vertex pos="4 -3 -1" />
                            <Vertex pos="-4 3 1" />
                            <Vertex pos="-4 3 -1" />
                            <Vertex pos="-4 -3 1" />
                            <Vertex pos="-4 -3 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -128 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_friction_bounce_low" texgens="1 0 0 -512 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile03_A" texgens="1 0 0 0 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="102" owner="0" type="0" pos="-2 21 9" rot="1 0 0 0" scale="" transform="1 0 0 -2 0 1 0 21 0 0 1 9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 3 2" />
                            <Vertex pos="4 3 -2" />
                            <Vertex pos="4 -3 2" />
                            <Vertex pos="4 -3 -2" />
                            <Vertex pos="-4 3 2" />
                            <Vertex pos="-4 3 -2" />
                            <Vertex pos="-4 -3 2" />
                            <Vertex pos="-4 -3 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 1408 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -1408 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_friction_sand" texgens="1 0 0 0 0 -1 0 -2304 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="103" owner="0" type="0" pos="-4 7 7" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 7 0 0 1 7 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 4.76837e-007" />
                            <Vertex pos="2 1 -2" />
                            <Vertex pos="2 -1 2" />
                            <Vertex pos="2 -1 -4.76837e-007" />
                            <Vertex pos="-2 1 4.76837e-007" />
                            <Vertex pos="-2 1 -2" />
                            <Vertex pos="-2 -1 2" />
                            <Vertex pos="-2 -1 -4.76837e-007" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 896 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 -896 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707107 -0.707107" album="" material="bm_tile03_A" texgens="1 0 0 0 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.707107 -0.707107 -0.707107" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="104" owner="0" type="0" pos="-60 65 -6" rot="1 0 0 0" scale="" transform="1 0 0 -60 0 1 0 65 0 0 1 -6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 11" />
                            <Vertex pos="2 1 -11" />
                            <Vertex pos="2 -1 11" />
                            <Vertex pos="2 -1 -11" />
                            <Vertex pos="-2 1 11" />
                            <Vertex pos="-2 1 -11" />
                            <Vertex pos="-2 -1 11" />
                            <Vertex pos="-2 -1 -11" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -640 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 640 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_friction_bounce_high" texgens="1 0 0 0 0 0 -1 3328 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -11" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -11" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="105" owner="0" type="0" pos="-57.75 64.25 4" rot="1 0 0 0" scale="" transform="1 0 0 -57.75 0 1 0 64.25 0 0 1 4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 1" />
                            <Vertex pos="0.25 0.25 -1" />
                            <Vertex pos="0.25 -0.25 1" />
                            <Vertex pos="0.25 -0.25 -1" />
                            <Vertex pos="-0.25 0.25 1" />
                            <Vertex pos="-0.25 0.25 -1" />
                            <Vertex pos="-0.25 -0.25 1" />
                            <Vertex pos="-0.25 -0.25 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3136 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -3008 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1216 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1088 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_edge_white" texgens="1 0 0 -1088 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_edge_white" texgens="-1 0 0 1216 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="106" owner="0" type="0" pos="-62.25 64.25 4" rot="1 0 0 0" scale="" transform="1 0 0 -62.25 0 1 0 64.25 0 0 1 4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 1" />
                            <Vertex pos="0.25 0.25 -1" />
                            <Vertex pos="0.25 -0.25 1" />
                            <Vertex pos="0.25 -0.25 -1" />
                            <Vertex pos="-0.25 0.25 1" />
                            <Vertex pos="-0.25 0.25 -1" />
                            <Vertex pos="-0.25 -0.25 1" />
                            <Vertex pos="-0.25 -0.25 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3136 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -3008 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1216 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1088 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_edge_white" texgens="1 0 0 -1088 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_edge_white" texgens="-1 0 0 1216 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="107" owner="0" type="0" pos="-3 13 -8" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 13 0 0 1 -8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 5 5" />
                            <Vertex pos="3 5 -9" />
                            <Vertex pos="3 -5 5" />
                            <Vertex pos="3 -5 -9" />
                            <Vertex pos="-3 5 5" />
                            <Vertex pos="-3 5 -9" />
                            <Vertex pos="-3 -5 5" />
                            <Vertex pos="-3 -5 -9" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 1152 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 -1152 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -5" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -5" album="" material="bm_tile03_A" texgens="1 0 0 -256 0 -1 0 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -9" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="108" owner="0" type="0" pos="-59 23 -10" rot="1 0 0 0" scale="" transform="1 0 0 -59 0 1 0 23 0 0 1 -10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 5" />
                            <Vertex pos="3 3 -7" />
                            <Vertex pos="3 -3 5" />
                            <Vertex pos="3 -3 -7" />
                            <Vertex pos="-3 3 7" />
                            <Vertex pos="-3 3 -7" />
                            <Vertex pos="-3 -3 7" />
                            <Vertex pos="-3 -3 -7" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 -640 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 640 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -384 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.316228 0 0.948683 -5.6921" album="" material="bm_stripe_caution2" texgens="1 1 0 768 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -7" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="109" owner="0" type="0" pos="-2 21 -13" rot="1 0 0 0" scale="" transform="1 0 0 -2 0 1 0 21 0 0 1 -13 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="10 3 4" />
                            <Vertex pos="10 3 -4" />
                            <Vertex pos="10 -3 4" />
                            <Vertex pos="10 -3 -4" />
                            <Vertex pos="-10 3 4" />
                            <Vertex pos="-10 3 -4" />
                            <Vertex pos="-10 -3 4" />
                            <Vertex pos="-10 -3 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -10" album="" material="bm_grid_blank4" texgens="0 1 0 1408 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -10" album="" material="bm_grid_blank4" texgens="0 -1 0 -1408 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_friction_bounce_med" texgens="1 0 0 1536 0 -1 0 -2304 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="110" owner="0" type="0" pos="-39 21 -8" rot="1 0 0 0" scale="" transform="1 0 0 -39 0 1 0 21 0 0 1 -8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 3 7" />
                            <Vertex pos="5 3 -9" />
                            <Vertex pos="5 -3 7" />
                            <Vertex pos="5 -3 -9" />
                            <Vertex pos="-5 3 7" />
                            <Vertex pos="-5 3 -9" />
                            <Vertex pos="-5 -3 7" />
                            <Vertex pos="-5 -3 -9" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_grid_blank4" texgens="0 1 0 1408 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="" material="bm_grid_blank4" texgens="0 -1 0 -1408 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7" album="" material="bm_tile03_A" texgens="1 0 0 256 0 -1 0 -2304 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -9" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="111" owner="0" type="0" pos="23 21 7" rot="1 0 0 0" scale="" transform="1 0 0 23 0 1 0 21 0 0 1 7 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 4" />
                            <Vertex pos="3 3 -4" />
                            <Vertex pos="3 -3 4" />
                            <Vertex pos="3 -3 -4" />
                            <Vertex pos="-3 3 4" />
                            <Vertex pos="-3 3 -4" />
                            <Vertex pos="-3 -3 4" />
                            <Vertex pos="-3 -3 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 -1920 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 1920 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -384 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_tile03_A" texgens="1 0 0 -768 0 -1 0 4352 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="112" owner="0" type="0" pos="23 21 -1" rot="1 0 0 0" scale="" transform="1 0 0 23 0 1 0 21 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 3 4" />
                            <Vertex pos="-1 3 -4" />
                            <Vertex pos="-1 -3 4" />
                            <Vertex pos="-1 -3 -4" />
                            <Vertex pos="-3 3 4" />
                            <Vertex pos="-3 3 -4" />
                            <Vertex pos="-3 -3 4" />
                            <Vertex pos="-3 -3 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 1" album="" material="bm_grid_blank4" texgens="0 1 0 -1920 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_friction_sand" texgens="0 -1 0 -256 0 0 -1 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -384 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_tile03_A" texgens="1 0 0 -768 0 -1 0 4352 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="113" owner="0" type="0" pos="-4.25 3 0.75" rot="1 0 0 0" scale="" transform="1 0 0 -4.25 0 1 0 3 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 5 0.25" />
                            <Vertex pos="0.25 5 -0.25" />
                            <Vertex pos="0.25 -5 0.25" />
                            <Vertex pos="0.25 -5 -0.25" />
                            <Vertex pos="-0.25 5 0.25" />
                            <Vertex pos="-0.25 5 -0.25" />
                            <Vertex pos="-0.25 -5 0.25" />
                            <Vertex pos="-0.25 -5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1792 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -5" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 -1 0 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 -1 0 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="114" owner="0" type="0" pos="2.25 3 0.75" rot="1 0 0 0" scale="" transform="1 0 0 2.25 0 1 0 3 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 5 0.25" />
                            <Vertex pos="0.25 5 -0.25" />
                            <Vertex pos="0.25 -5 0.25" />
                            <Vertex pos="0.25 -5 -0.25" />
                            <Vertex pos="-0.25 5 0.25" />
                            <Vertex pos="-0.25 5 -0.25" />
                            <Vertex pos="-0.25 -5 0.25" />
                            <Vertex pos="-0.25 -5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1792 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -5" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 -1 0 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 -1 0 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="115" owner="0" type="0" pos="2.25 9 0.5" rot="1 0 0 0" scale="" transform="1 0 0 2.25 0 1 0 9 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1 5.96046e-008" />
                            <Vertex pos="0.25 1 -0.5" />
                            <Vertex pos="0.25 -1 0.5" />
                            <Vertex pos="0.25 -1 -2.98023e-007" />
                            <Vertex pos="-0.25 1 5.96046e-008" />
                            <Vertex pos="-0.25 1 -0.5" />
                            <Vertex pos="-0.25 -1 0.5" />
                            <Vertex pos="-0.25 -1 -2.98023e-007" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 896 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970143 -0.242536" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970143 -0.242536" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="116" owner="0" type="0" pos="2.25 13 -1" rot="1 0 0 0" scale="" transform="1 0 0 2.25 0 1 0 13 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1 5.96046e-008" />
                            <Vertex pos="0.25 1 -0.5" />
                            <Vertex pos="0.25 -1 0.5" />
                            <Vertex pos="0.25 -1 -5.96046e-008" />
                            <Vertex pos="-0.25 1 5.96046e-008" />
                            <Vertex pos="-0.25 1 -0.5" />
                            <Vertex pos="-0.25 -1 0.5" />
                            <Vertex pos="-0.25 -1 -5.96046e-008" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 896 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970143 -0.242536" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970143 -0.242536" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="117" owner="0" type="0" pos="2.25 11 -0.25" rot="1 0 0 0" scale="" transform="1 0 0 2.25 0 1 0 11 0 0 1 -0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1 -0.25" />
                            <Vertex pos="0.25 1 -0.75" />
                            <Vertex pos="0.25 -1 0.75" />
                            <Vertex pos="0.25 -1 0.25" />
                            <Vertex pos="-0.25 1 -0.25" />
                            <Vertex pos="-0.25 1 -0.75" />
                            <Vertex pos="-0.25 -1 0.75" />
                            <Vertex pos="-0.25 -1 0.25" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 896 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -768 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.447214 0.894427 -0.223607" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.447214 -0.894427 -0.223607" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="118" owner="0" type="0" pos="2.25 19 -1.25" rot="1 0 0 0" scale="" transform="1 0 0 2.25 0 1 0 19 0 0 1 -1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 5 0.25" />
                            <Vertex pos="0.25 5 -0.25" />
                            <Vertex pos="0.25 -5 0.25" />
                            <Vertex pos="0.25 -5 -0.25" />
                            <Vertex pos="-0.25 5 0.25" />
                            <Vertex pos="-0.25 5 -0.25" />
                            <Vertex pos="-0.25 -5 0.25" />
                            <Vertex pos="-0.25 -5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1792 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -5" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 -1 0 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 -1 0 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="119" owner="0" type="0" pos="2.25 19 2.75" rot="1 0 0 0" scale="" transform="1 0 0 2.25 0 1 0 19 0 0 1 2.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3 0.25" />
                            <Vertex pos="0.25 3 -0.25" />
                            <Vertex pos="0.25 -3 0.25" />
                            <Vertex pos="0.25 -3 -0.25" />
                            <Vertex pos="-0.25 3 0.25" />
                            <Vertex pos="-0.25 3 -0.25" />
                            <Vertex pos="-0.25 -3 0.25" />
                            <Vertex pos="-0.25 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2432 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2304 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 -1 0 -2304 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 -1 0 -2304 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="120" owner="0" type="0" pos="2.25 13 4.75" rot="1 0 0 0" scale="" transform="1 0 0 2.25 0 1 0 13 0 0 1 4.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3 0.25" />
                            <Vertex pos="0.25 3 -0.25" />
                            <Vertex pos="0.25 -3 0.25" />
                            <Vertex pos="0.25 -3 -0.25" />
                            <Vertex pos="-0.25 3 0.25" />
                            <Vertex pos="-0.25 3 -0.25" />
                            <Vertex pos="-0.25 -3 0.25" />
                            <Vertex pos="-0.25 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2432 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2304 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 -1 0 -2304 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 -1 0 -2304 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="121" owner="0" type="0" pos="2.25 15.75 3.5" rot="1 0 0 0" scale="" transform="1 0 0 2.25 0 1 0 15.75 0 0 1 3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 1" />
                            <Vertex pos="0.25 0.25 -1" />
                            <Vertex pos="0.25 -0.25 1" />
                            <Vertex pos="0.25 -0.25 -1" />
                            <Vertex pos="-0.25 0.25 1" />
                            <Vertex pos="-0.25 0.25 -1" />
                            <Vertex pos="-0.25 -0.25 1" />
                            <Vertex pos="-0.25 -0.25 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3136 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -3008 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="122" owner="0" type="0" pos="2.25 24.25 3" rot="1 0 0 0" scale="" transform="1 0 0 2.25 0 1 0 24.25 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 4.5" />
                            <Vertex pos="0.25 0.25 -4.5" />
                            <Vertex pos="0.25 -0.25 4.5" />
                            <Vertex pos="0.25 -0.25 -4.5" />
                            <Vertex pos="-0.25 0.25 4.5" />
                            <Vertex pos="-0.25 0.25 -4.5" />
                            <Vertex pos="-0.25 -0.25 4.5" />
                            <Vertex pos="-0.25 -0.25 -4.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3136 0 0 -1 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -3008 0 0 -1 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 0 -1 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 0 -1 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4.5" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4.5" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="123" owner="0" type="0" pos="2.25 21.25 7.25" rot="1 0 0 0" scale="" transform="1 0 0 2.25 0 1 0 21.25 0 0 1 7.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2.75 0.25" />
                            <Vertex pos="0.25 2.75 -0.25" />
                            <Vertex pos="0.25 -2.75 0.25" />
                            <Vertex pos="0.25 -2.75 -0.25" />
                            <Vertex pos="-0.25 2.75 0.25" />
                            <Vertex pos="-0.25 2.75 -0.25" />
                            <Vertex pos="-0.25 -2.75 0.25" />
                            <Vertex pos="-0.25 -2.75 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2496 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2368 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.75" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2.75" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 -1 0 -2368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 -1 0 -2368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="124" owner="0" type="0" pos="2.25 24.25 10.75" rot="1 0 0 0" scale="" transform="1 0 0 2.25 0 1 0 24.25 0 0 1 10.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 5.75 0.25" />
                            <Vertex pos="0.25 5.75 -0.25" />
                            <Vertex pos="0.25 -5.75 0.25" />
                            <Vertex pos="0.25 -5.75 -0.25" />
                            <Vertex pos="-0.25 5.75 0.25" />
                            <Vertex pos="-0.25 5.75 -0.25" />
                            <Vertex pos="-0.25 -5.75 0.25" />
                            <Vertex pos="-0.25 -5.75 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3264 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -3136 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -5.75" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.75" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 -1 0 -3136 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 -1 0 -3136 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="125" owner="0" type="0" pos="2.25 18.25 9" rot="1 0 0 0" scale="" transform="1 0 0 2.25 0 1 0 18.25 0 0 1 9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 2" />
                            <Vertex pos="0.25 0.25 -2" />
                            <Vertex pos="0.25 -0.25 2" />
                            <Vertex pos="0.25 -0.25 -2" />
                            <Vertex pos="-0.25 0.25 2" />
                            <Vertex pos="-0.25 0.25 -2" />
                            <Vertex pos="-0.25 -0.25 2" />
                            <Vertex pos="-0.25 -0.25 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3136 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -3008 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="126" owner="0" type="0" pos="2.25 9 6.75" rot="1 0 0 0" scale="" transform="1 0 0 2.25 0 1 0 9 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1 0.25" />
                            <Vertex pos="0.25 1 -0.25" />
                            <Vertex pos="0.25 -1 0.25" />
                            <Vertex pos="0.25 -1 -0.25" />
                            <Vertex pos="-0.25 1 0.25" />
                            <Vertex pos="-0.25 1 -0.25" />
                            <Vertex pos="-0.25 -1 0.25" />
                            <Vertex pos="-0.25 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2944 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2816 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 -1 0 -2816 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 -1 0 -2816 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="127" owner="0" type="0" pos="2.25 9.75 5.5" rot="1 0 0 0" scale="" transform="1 0 0 2.25 0 1 0 9.75 0 0 1 5.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 1" />
                            <Vertex pos="0.25 0.25 -1" />
                            <Vertex pos="0.25 -0.25 1" />
                            <Vertex pos="0.25 -0.25 -1" />
                            <Vertex pos="-0.25 0.25 1" />
                            <Vertex pos="-0.25 0.25 -1" />
                            <Vertex pos="-0.25 -0.25 1" />
                            <Vertex pos="-0.25 -0.25 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3136 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -3008 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="128" owner="0" type="0" pos="-1.75 7 7.75" rot="1 0 0 0" scale="" transform="1 0 0 -1.75 0 1 0 7 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1 -0.749999" />
                            <Vertex pos="0.25 1 -1.25" />
                            <Vertex pos="0.25 -1 1.25" />
                            <Vertex pos="0.25 -1 0.749999" />
                            <Vertex pos="-0.25 1 -0.749999" />
                            <Vertex pos="-0.25 1 -1.25" />
                            <Vertex pos="-0.25 -1 1.25" />
                            <Vertex pos="-0.25 -1 0.749999" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2944 0 0 -1 -192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2816 0 0 -1 -192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 0 -1 -192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 0 -1 -192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707107 -0.176778" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 -1 0 -2816 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.707107 -0.707107 -0.176777" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 -1 0 -2816 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="129" owner="0" type="0" pos="0.5 7.75 6.75" rot="1 0 0 0" scale="" transform="1 0 0 0.5 0 1 0 7.75 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 0.25" />
                            <Vertex pos="2 0.25 -0.25" />
                            <Vertex pos="2 -0.25 0.25" />
                            <Vertex pos="2 -0.25 -0.25" />
                            <Vertex pos="-2 0.25 0.25" />
                            <Vertex pos="-2 0.25 -0.25" />
                            <Vertex pos="-2 -0.25 0.25" />
                            <Vertex pos="-2 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 3136 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1280 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1152 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1152 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1280 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="130" owner="0" type="0" pos="-6.25 7 7.75" rot="1 0 0 0" scale="" transform="1 0 0 -6.25 0 1 0 7 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1 -0.749999" />
                            <Vertex pos="0.25 1 -1.25" />
                            <Vertex pos="0.25 -1 1.25" />
                            <Vertex pos="0.25 -1 0.749999" />
                            <Vertex pos="-0.25 1 -0.749999" />
                            <Vertex pos="-0.25 1 -1.25" />
                            <Vertex pos="-0.25 -1 1.25" />
                            <Vertex pos="-0.25 -1 0.749999" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2944 0 0 -1 -192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2816 0 0 -1 -192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 0 -1 -192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 0 -1 -192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707107 -0.176778" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 -1 0 -2816 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.707107 -0.707107 -0.176777" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 -1 0 -2816 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="131" owner="0" type="0" pos="-6.25 13 6.75" rot="1 0 0 0" scale="" transform="1 0 0 -6.25 0 1 0 13 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 5 0.25" />
                            <Vertex pos="0.25 5 -0.25" />
                            <Vertex pos="0.25 -5 0.25" />
                            <Vertex pos="0.25 -5 -0.25" />
                            <Vertex pos="-0.25 5 0.25" />
                            <Vertex pos="-0.25 5 -0.25" />
                            <Vertex pos="-0.25 -5 0.25" />
                            <Vertex pos="-0.25 -5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3968 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -3840 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -5" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 -1 0 -3840 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 -1 0 -3840 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="132" owner="0" type="0" pos="-6.25 29.75 10.75" rot="1 0 0 0" scale="" transform="1 0 0 -6.25 0 1 0 29.75 0 0 1 10.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 11.75 0.25" />
                            <Vertex pos="0.25 11.75 -0.25" />
                            <Vertex pos="0.25 -11.75 0.25" />
                            <Vertex pos="0.25 -11.75 -0.25" />
                            <Vertex pos="-0.25 11.75 0.25" />
                            <Vertex pos="-0.25 11.75 -0.25" />
                            <Vertex pos="-0.25 -11.75 0.25" />
                            <Vertex pos="-0.25 -11.75 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 4672 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -4544 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -11.75" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -11.75" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 -1 0 -4544 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 -1 0 -4544 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="133" owner="0" type="0" pos="-6.25 18.25 8.5" rot="1 0 0 0" scale="" transform="1 0 0 -6.25 0 1 0 18.25 0 0 1 8.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 2" />
                            <Vertex pos="0.25 0.25 -2" />
                            <Vertex pos="0.25 -0.25 2" />
                            <Vertex pos="0.25 -0.25 -2" />
                            <Vertex pos="-0.25 0.25 2" />
                            <Vertex pos="-0.25 0.25 -2" />
                            <Vertex pos="-0.25 -0.25 2" />
                            <Vertex pos="-0.25 -0.25 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3136 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -3008 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="134" owner="0" type="0" pos="0.25 39.25 10.75" rot="1 0 0 0" scale="" transform="1 0 0 0.25 0 1 0 39.25 0 0 1 10.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 9.25 0.25" />
                            <Vertex pos="0.25 9.25 -0.25" />
                            <Vertex pos="0.25 -9.25 0.25" />
                            <Vertex pos="0.25 -9.25 -0.25" />
                            <Vertex pos="-0.25 9.25 0.25" />
                            <Vertex pos="-0.25 9.25 -0.25" />
                            <Vertex pos="-0.25 -9.25 0.25" />
                            <Vertex pos="-0.25 -9.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 4160 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -4032 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -9.25" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -9.25" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 -1 0 -4032 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 -1 0 -4032 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="135" owner="0" type="0" pos="1.5 30.25 10.75" rot="1 0 0 0" scale="" transform="1 0 0 1.5 0 1 0 30.25 0 0 1 10.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 0.25" />
                            <Vertex pos="1 0.25 -0.25" />
                            <Vertex pos="1 -0.25 0.25" />
                            <Vertex pos="1 -0.25 -0.25" />
                            <Vertex pos="-1 0.25 0.25" />
                            <Vertex pos="-1 0.25 -0.25" />
                            <Vertex pos="-1 -0.25 0.25" />
                            <Vertex pos="-1 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 3136 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 -3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1408 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1536 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="136" owner="0" type="0" pos="-58 31.875 6.75" rot="1 0 0 0" scale="" transform="1 0 0 -58 0 1 0 31.875 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.5 0.125 0.25" />
                            <Vertex pos="4.5 0.125 -0.25" />
                            <Vertex pos="4.5 -0.125 0.25" />
                            <Vertex pos="4.5 -0.125 -0.25" />
                            <Vertex pos="-4.5 0.125 0.25" />
                            <Vertex pos="-4.5 0.125 -0.25" />
                            <Vertex pos="-4.5 -0.125 0.25" />
                            <Vertex pos="-4.5 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4.5" album="" material="bm_trim" texgens="0 1 0 8160 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4.5" album="" material="bm_trim" texgens="0 -1 0 -8160 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_trim" texgens="-1 0 0 14848 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_trim" texgens="1 0 0 -14848 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_trim" texgens="1 0 0 -14848 0 -1 0 -8160 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_trim" texgens="-1 0 0 14848 0 -1 0 -8160 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="137" owner="0" type="0" pos="-59 26.25 -4.24999" rot="1 0 0 0" scale="" transform="1 0 0 -59 0 1 0 26.25 0 0 1 -4.24999 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.5 0.25 -0.916663" />
                            <Vertex pos="-3.5 0.25 1.41666" />
                            <Vertex pos="3.5 0.25 -1.41666" />
                            <Vertex pos="-3.5 0.25 0.916649" />
                            <Vertex pos="3.5 -0.25 -0.916663" />
                            <Vertex pos="-3.5 -0.25 1.41666" />
                            <Vertex pos="3.5 -0.249998 -1.41666" />
                            <Vertex pos="-3.5 -0.249998 0.91665" />
                        </Vertices>
                        <Face id="0" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -768 -0.333333 0 -1 63.9961 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0.316227 9.04735e-007 0.948684 -0.237171" album="" material="bm_edge_white" texgens="1 0 0 -768 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="1 -0 0 -3.5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 -234.67 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="-1 0 0 -3.5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 362.667 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="-0.316225 0 -0.948684 -0.237177" album="" material="bm_edge_white" texgens="1 0 0 -768 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="-1.27153e-006 -1 -3.8146e-006 -0.249999" album="" material="bm_edge_white" texgens="-1 0 0 896 0 0 1 2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="138" owner="0" type="0" pos="-59 19.75 -4.24999" rot="1 0 0 0" scale="" transform="1 0 0 -59 0 1 0 19.75 0 0 1 -4.24999 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.5 -0.25 -0.916663" />
                            <Vertex pos="-3.5 -0.25 1.41666" />
                            <Vertex pos="3.5 -0.25 -1.41666" />
                            <Vertex pos="-3.5 -0.25 0.916649" />
                            <Vertex pos="3.5 0.25 -0.916663" />
                            <Vertex pos="-3.5 0.25 1.41666" />
                            <Vertex pos="3.5 0.25 -1.41666" />
                            <Vertex pos="-3.5 0.25 0.91665" />
                        </Vertices>
                        <Face id="0" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -768 -0.333333 0 -1 63.9961 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.316227 0 0.948684 -0.237171" album="" material="bm_edge_white" texgens="1 0 0 -768 0 -1 0 1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="1 0 0 -3.5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 -234.67 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="-1 0 -0 -3.5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 362.667 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0.316225 1.3571e-006 -0.948684 -0.237177" album="" material="bm_edge_white" texgens="1 0 0 -768 0 -1 0 1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 896 0 0 1 2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="139" owner="0" type="0" pos="-62.25 23 -3.16667" rot="1 0 0 0" scale="" transform="1 0 0 -62.25 0 1 0 23 0 0 1 -3.16667 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.249996 3 0.333334" />
                            <Vertex pos="-0.249996 3 -0.16668" />
                            <Vertex pos="-0.249996 -3 0.333334" />
                            <Vertex pos="-0.249996 -3 -0.16668" />
                            <Vertex pos="0.249996 3 0.166668" />
                            <Vertex pos="0.249996 3 -0.333333" />
                            <Vertex pos="0.249996 -3 0.166667" />
                            <Vertex pos="0.249996 -3 -0.333334" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.249996" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 85.335 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 1 0 -3" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 0 1 2709.33 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0.316231 -0 0.948682 -0.237171" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 -1 0 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="-0.316209 7.53951e-008 -0.94869 -0.237179" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 -1 0 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-5.08621e-006 -1 -3.81459e-006 -3" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 0 1 2709.33 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 -0 0 -0.249996" album="" material="bm_edge_white" texgens="0 1 0 1216 0 0 1 2709.33 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="140" owner="0" type="0" pos="-55.75 23 -5.33333" rot="1 0 0 0" scale="" transform="1 0 0 -55.75 0 1 0 23 0 0 1 -5.33333 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3 0.166671" />
                            <Vertex pos="0.25 3 -0.333328" />
                            <Vertex pos="0.25 -3 0.166671" />
                            <Vertex pos="0.25 -3 -0.333328" />
                            <Vertex pos="-0.25 3 0.333328" />
                            <Vertex pos="-0.25 3 -0.166672" />
                            <Vertex pos="-0.25 -3 0.333327" />
                            <Vertex pos="-0.25 -3 -0.166672" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 42.6581 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 1 2154.67 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0.31621 -7.5395e-008 0.948689 -0.237172" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="-0.31621 0 -0.948689 -0.237173" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 1 2154.67 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 1216 0 0 1 2154.67 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="141" owner="0" type="0" pos="26.25 21 10.75" rot="1 0 0 0" scale="" transform="1 0 0 26.25 0 1 0 21 0 0 1 10.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3 0.25" />
                            <Vertex pos="0.25 3 -0.25" />
                            <Vertex pos="0.25 -3 0.25" />
                            <Vertex pos="0.25 -3 -0.25" />
                            <Vertex pos="-0.25 3 0.25" />
                            <Vertex pos="-0.25 3 -0.25" />
                            <Vertex pos="-0.25 -3 0.25" />
                            <Vertex pos="-0.25 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2560 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2432 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="142" owner="0" type="0" pos="27.5 18.25 10.75" rot="1 0 0 0" scale="" transform="1 0 0 27.5 0 1 0 18.25 0 0 1 10.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 0.25" />
                            <Vertex pos="1 0.25 -0.25" />
                            <Vertex pos="1 -0.25 0.25" />
                            <Vertex pos="1 -0.25 -0.25" />
                            <Vertex pos="-1 0.25 0.25" />
                            <Vertex pos="-1 0.25 -0.25" />
                            <Vertex pos="-1 -0.25 0.25" />
                            <Vertex pos="-1 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 3136 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 -3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1408 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1536 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="143" owner="0" type="0" pos="23.25 24.25 10.75" rot="1 0 0 0" scale="" transform="1 0 0 23.25 0 1 0 24.25 0 0 1 10.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.25 0.25 0.25" />
                            <Vertex pos="3.25 0.25 -0.25" />
                            <Vertex pos="3.25 -0.25 0.25" />
                            <Vertex pos="3.25 -0.25 -0.25" />
                            <Vertex pos="-3.25 0.25 0.25" />
                            <Vertex pos="-3.25 0.25 -0.25" />
                            <Vertex pos="-3.25 -0.25 0.25" />
                            <Vertex pos="-3.25 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3.25" album="" material="bm_edge_white" texgens="0 1 0 3136 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3.25" album="" material="bm_edge_white" texgens="0 -1 0 -3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 960 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -832 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -832 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 960 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="144" owner="0" type="0" pos="-46 -34 11" rot="1 0 0 0" scale="" transform="1 0 0 -46 0 1 0 -34 0 0 1 11 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 28" />
                            <Vertex pos="2 4 -28" />
                            <Vertex pos="2 -4 28" />
                            <Vertex pos="2 -4 -28" />
                            <Vertex pos="-2 4 28" />
                            <Vertex pos="-2 4 -28" />
                            <Vertex pos="-2 -4 28" />
                            <Vertex pos="-2 -4 -28" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -1792 0 0 -1 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 1792 0 0 -1 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -4096 0 0 -1 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 4096 0 0 -1 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -28" album="" material="bm_tile03_A" texgens="1 0 0 8192 0 -1 0 4096 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -28" album="" material="bm_grid_blank4" texgens="-1 0 0 -4096 0 -1 0 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="145" owner="0" type="0" pos="-34 -34 35" rot="1 0 0 0" scale="" transform="1 0 0 -34 0 1 0 -34 0 0 1 35 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="10 4 4" />
                            <Vertex pos="10 4 -4" />
                            <Vertex pos="10 -4 4" />
                            <Vertex pos="10 -4 -4" />
                            <Vertex pos="-10 4 4" />
                            <Vertex pos="-10 4 -4" />
                            <Vertex pos="-10 -4 4" />
                            <Vertex pos="-10 -4 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -10" album="" material="bm_grid_blank4" texgens="0 1 0 -1792 0 0 -1 -4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -10" album="" material="bm_grid_blank4" texgens="0 -1 0 1792 0 0 -1 -4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -5120 0 0 -1 -4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 5120 0 0 -1 -4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_tile03_A" texgens="1 0 0 10240 0 -1 0 4096 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -5120 0 -1 0 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="195" owner="0" type="0" pos="-26 -42.25 39.25" rot="1 0 0 0" scale="" transform="1 0 0 -26 0 1 0 -42.25 0 0 1 39.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 0.25 1.75" />
                            <Vertex pos="0 2.25 -0.25" />
                            <Vertex pos="-1 -1.75 1.75" />
                            <Vertex pos="0 -3.75 -0.25" />
                            <Vertex pos="-1 0.25 1.75" />
                            <Vertex pos="-2 2.25 -0.25" />
                            <Vertex pos="-1 -1.75 1.75" />
                            <Vertex pos="-2 -3.75 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.894427 -0 0.447214 0.111803" album="" material="bm_friction_sand" texgens="0 1 0 3136 0 0 -1 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.894427 0 0.447214 -1.67705" album="" material="bm_friction_sand" texgens="0 -1 0 -3008 0 0 -1 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 0.707107 0.707107 -1.41421" album="" material="bm_friction_sand" texgens="-1 0 0 768 0 0 -1 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.707107 0.707107 -2.47487" album="" material="bm_friction_sand" texgens="1 0 0 -640 0 0 -1 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 1 -1.75" album="" material="bm_friction_sand" texgens="1 0 0 -640 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_friction_sand" texgens="-1 0 0 768 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="196" owner="0" type="0" pos="-40 -22.25 39.25" rot="1 0 0 0" scale="" transform="1 0 0 -40 0 1 0 -22.25 0 0 1 39.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1.75 1.75" />
                            <Vertex pos="0 0.25 -0.25" />
                            <Vertex pos="-1 -3.75 1.75" />
                            <Vertex pos="0 -5.75 -0.25" />
                            <Vertex pos="-1 -1.75 1.75" />
                            <Vertex pos="-2 0.25 -0.25" />
                            <Vertex pos="-1 -3.75 1.75" />
                            <Vertex pos="-2 -5.75 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.894427 -0 0.447214 0.111803" album="" material="bm_friction_sand" texgens="0 1 0 3136 0 0 -1 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.894427 0 0.447214 -1.67705" album="" material="bm_friction_sand" texgens="0 -1 0 -3008 0 0 -1 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 0.707107 0.707107 -0" album="" material="bm_friction_sand" texgens="-1 0 0 768 0 0 -1 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.707107 0.707107 -3.88909" album="" material="bm_friction_sand" texgens="1 0 0 -640 0 0 -1 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 1 -1.75" album="" material="bm_friction_sand" texgens="1 0 0 -640 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_friction_sand" texgens="-1 0 0 768 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="197" owner="0" type="0" pos="-36 -36.25 39.25" rot="1 0 0 0" scale="" transform="1 0 0 -36 0 1 0 -36.25 0 0 1 39.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 -2.75 1.75" />
                            <Vertex pos="6 -1.75 -0.25" />
                            <Vertex pos="4 -2.75 1.75" />
                            <Vertex pos="6 -3.75 -0.25" />
                            <Vertex pos="0 -2.75 1.75" />
                            <Vertex pos="-2 -1.75 -0.25" />
                            <Vertex pos="0 -2.75 1.75" />
                            <Vertex pos="-2 -3.75 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0 0.707107 -4.06586" album="" material="bm_friction_sand" texgens="0 1 0 3136 0 0 -1 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0 0.707107 -1.23744" album="" material="bm_friction_sand" texgens="0 -1 0 -3008 0 0 -1 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 0.894427 0.447214 1.67705" album="" material="bm_friction_sand" texgens="-1 0 0 768 0 0 -1 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.894427 0.447214 -3.2423" album="" material="bm_friction_sand" texgens="1 0 0 -640 0 0 -1 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 1 -1.75" album="" material="bm_friction_sand" texgens="1 0 0 -640 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_friction_sand" texgens="-1 0 0 768 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="198" owner="0" type="0" pos="-38 17.75 -1.25" rot="1 0 0 0" scale="" transform="1 0 0 -38 0 1 0 17.75 0 0 1 -1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.25 0.25" />
                            <Vertex pos="4 0.25 -0.25" />
                            <Vertex pos="4 -0.25 0.25" />
                            <Vertex pos="4 -0.25 -0.25" />
                            <Vertex pos="-6 0.25 0.25" />
                            <Vertex pos="-6 0.25 -0.25" />
                            <Vertex pos="-6 -0.25 0.25" />
                            <Vertex pos="-6 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 3136 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 -3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2048 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1920 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2048 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="199" owner="0" type="0" pos="-33.875 24 -1.25" rot="1 0 0 0" scale="" transform="1 0 0 -33.875 0 1 0 24 0 0 1 -1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 0.5 0.25" />
                            <Vertex pos="0.125 0.5 -0.25" />
                            <Vertex pos="0.125 -6.5 0.25" />
                            <Vertex pos="0.125 -6.5 -0.25" />
                            <Vertex pos="-0.125 0.5 0.25" />
                            <Vertex pos="-0.125 0.5 -0.25" />
                            <Vertex pos="-0.125 -6.5 0.25" />
                            <Vertex pos="-0.125 -6.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_trim" texgens="0 1 0 6144 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_trim" texgens="0 -1 0 -6144 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_trim" texgens="-1 0 0 8672 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6.5" album="" material="bm_trim" texgens="1 0 0 -8672 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_trim" texgens="1 0 0 -8672 0 -1 0 -6144 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_trim" texgens="-1 0 0 8672 0 -1 0 -6144 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="200" owner="0" type="0" pos="-38 24.25 -1.25" rot="1 0 0 0" scale="" transform="1 0 0 -38 0 1 0 24.25 0 0 1 -1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.25 0.25" />
                            <Vertex pos="4 0.25 -0.25" />
                            <Vertex pos="4 -0.25 0.25" />
                            <Vertex pos="4 -0.25 -0.25" />
                            <Vertex pos="-6 0.25 0.25" />
                            <Vertex pos="-6 0.25 -0.25" />
                            <Vertex pos="-6 -0.25 0.25" />
                            <Vertex pos="-6 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 3136 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 -3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2048 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1920 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2048 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="201" owner="0" type="0" pos="-44.125 21 -1.25" rot="1 0 0 0" scale="" transform="1 0 0 -44.125 0 1 0 21 0 0 1 -1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 3.5 0.25" />
                            <Vertex pos="0.125 3.5 -0.25" />
                            <Vertex pos="0.125 -3.5 0.25" />
                            <Vertex pos="0.125 -3.5 -0.25" />
                            <Vertex pos="-0.125 3.5 0.25" />
                            <Vertex pos="-0.125 3.5 -0.25" />
                            <Vertex pos="-0.125 -3.5 0.25" />
                            <Vertex pos="-0.125 -3.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_trim" texgens="0 1 0 5376 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_trim" texgens="0 -1 0 -5376 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3.5" album="" material="bm_trim" texgens="-1 0 0 11296 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3.5" album="" material="bm_trim" texgens="1 0 0 -11296 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_trim" texgens="1 0 0 -11296 0 -1 0 -5376 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_trim" texgens="-1 0 0 11296 0 -1 0 -5376 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="202" owner="0" type="0" pos="8.125 24 -9.25" rot="1 0 0 0" scale="" transform="1 0 0 8.125 0 1 0 24 0 0 1 -9.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 0.25 0.25" />
                            <Vertex pos="0.125 0.25 -0.25" />
                            <Vertex pos="0.125 -6.25 0.25" />
                            <Vertex pos="0.125 -6.25 -0.25" />
                            <Vertex pos="-0.125 0.25 0.25" />
                            <Vertex pos="-0.125 0.25 -0.25" />
                            <Vertex pos="-0.125 -6.25 0.25" />
                            <Vertex pos="-0.125 -6.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_trim" texgens="0 1 0 6144 0 0 -1 2368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_trim" texgens="0 -1 0 -6144 0 0 -1 2368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_trim" texgens="-1 0 0 -2080 0 0 -1 2368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6.25" album="" material="bm_trim" texgens="1 0 0 2080 0 0 -1 2368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_trim" texgens="1 0 0 2080 0 -1 0 -6144 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_trim" texgens="-1 0 0 -2080 0 -1 0 -6144 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="203" owner="0" type="0" pos="-12.125 21 -9.25" rot="1 0 0 0" scale="" transform="1 0 0 -12.125 0 1 0 21 0 0 1 -9.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 3.25 0.25" />
                            <Vertex pos="0.125 3.25 -0.25" />
                            <Vertex pos="0.125 -3.25 0.25" />
                            <Vertex pos="0.125 -3.25 -0.25" />
                            <Vertex pos="-0.125 3.25 0.25" />
                            <Vertex pos="-0.125 3.25 -0.25" />
                            <Vertex pos="-0.125 -3.25 0.25" />
                            <Vertex pos="-0.125 -3.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_trim" texgens="0 1 0 5376 0 0 -1 2368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_trim" texgens="0 -1 0 -5376 0 0 -1 2368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3.25" album="" material="bm_trim" texgens="-1 0 0 3104 0 0 -1 2368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3.25" album="" material="bm_trim" texgens="1 0 0 -3104 0 0 -1 2368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_trim" texgens="1 0 0 -3104 0 -1 0 -5376 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_trim" texgens="-1 0 0 3104 0 -1 0 -5376 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="205" owner="0" type="0" pos="-11.625 21 -9.25" rot="1 0 0 0" scale="" transform="1 0 0 -11.625 0 1 0 21 0 0 1 -9.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5.625 -3 0.25" />
                            <Vertex pos="5.625 -3 -0.25" />
                            <Vertex pos="5.625 -3.25 0.25" />
                            <Vertex pos="5.625 -3.25 -0.25" />
                            <Vertex pos="-0.375 -3 0.25" />
                            <Vertex pos="-0.375 -3 -0.25" />
                            <Vertex pos="-0.375 -3.25 0.25" />
                            <Vertex pos="-0.375 -3.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5.625" album="" material="bm_trim" texgens="0 1 0 5376 0 0 -1 2368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.375" album="" material="bm_trim" texgens="0 -1 0 -5376 0 0 -1 2368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3" album="" material="bm_trim" texgens="-1 0 0 2976 0 0 -1 2368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3.25" album="" material="bm_trim" texgens="1 0 0 -2976 0 0 -1 2368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_trim" texgens="1 0 0 -2976 0 -1 0 -5376 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_trim" texgens="-1 0 0 2976 0 -1 0 -5376 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="206" owner="0" type="0" pos="-11.625 27.5 -9.25" rot="1 0 0 0" scale="" transform="1 0 0 -11.625 0 1 0 27.5 0 0 1 -9.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5.625 -3.25 0.25" />
                            <Vertex pos="5.625 -3.25 -0.25" />
                            <Vertex pos="5.625 -3.5 0.25" />
                            <Vertex pos="5.625 -3.5 -0.25" />
                            <Vertex pos="-0.375 -3.25 0.25" />
                            <Vertex pos="-0.375 -3.25 -0.25" />
                            <Vertex pos="-0.375 -3.5 0.25" />
                            <Vertex pos="-0.375 -3.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5.625" album="" material="bm_trim" texgens="0 1 0 7040 0 0 -1 2368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.375" album="" material="bm_trim" texgens="0 -1 0 -7040 0 0 -1 2368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.25" album="" material="bm_trim" texgens="-1 0 0 2976 0 0 -1 2368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3.5" album="" material="bm_trim" texgens="1 0 0 -2976 0 0 -1 2368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_trim" texgens="1 0 0 -2976 0 -1 0 -7040 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_trim" texgens="-1 0 0 2976 0 -1 0 -7040 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="207" owner="0" type="0" pos="7.625 24 -9.25" rot="1 0 0 0" scale="" transform="1 0 0 7.625 0 1 0 24 0 0 1 -9.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.375 -6 0.25" />
                            <Vertex pos="0.375 -6 -0.25" />
                            <Vertex pos="0.375 -6.25 0.25" />
                            <Vertex pos="0.375 -6.25 -0.25" />
                            <Vertex pos="-7.625 -6 0.25" />
                            <Vertex pos="-7.625 -6 -0.25" />
                            <Vertex pos="-7.625 -6.25 0.25" />
                            <Vertex pos="-7.625 -6.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.375" album="" material="bm_trim" texgens="0 1 0 6144 0 0 -1 2368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -7.625" album="" material="bm_trim" texgens="0 -1 0 -6144 0 0 -1 2368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 6" album="" material="bm_trim" texgens="-1 0 0 -1952 0 0 -1 2368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6.25" album="" material="bm_trim" texgens="1 0 0 1952 0 0 -1 2368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_trim" texgens="1 0 0 1952 0 -1 0 -6144 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_trim" texgens="-1 0 0 -1952 0 -1 0 -6144 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="208" owner="0" type="0" pos="2.375 27.5 -9.25" rot="1 0 0 0" scale="" transform="1 0 0 2.375 0 1 0 27.5 0 0 1 -9.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5.625 -3.25 0.25" />
                            <Vertex pos="5.625 -3.25 -0.25" />
                            <Vertex pos="5.625 -3.5 0.25" />
                            <Vertex pos="5.625 -3.5 -0.25" />
                            <Vertex pos="-0.375 -3.25 0.25" />
                            <Vertex pos="-0.375 -3.25 -0.25" />
                            <Vertex pos="-0.375 -3.5 0.25" />
                            <Vertex pos="-0.375 -3.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5.625" album="" material="bm_trim" texgens="0 1 0 7040 0 0 -1 2368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.375" album="" material="bm_trim" texgens="0 -1 0 -7040 0 0 -1 2368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.25" album="" material="bm_trim" texgens="-1 0 0 -608 0 0 -1 2368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3.5" album="" material="bm_trim" texgens="1 0 0 608 0 0 -1 2368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_trim" texgens="1 0 0 608 0 -1 0 -7040 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_trim" texgens="-1 0 0 -608 0 -1 0 -7040 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="209" owner="0" type="0" pos="23.25 24.25 10.25" rot="1 0 0 0" scale="" transform="1 0 0 23.25 0 1 0 24.25 0 0 1 10.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-2.75 0.25 0.25" />
                            <Vertex pos="-2.75 0.25 -15.75" />
                            <Vertex pos="-2.75 -0.25 0.25" />
                            <Vertex pos="-2.75 -0.25 -15.75" />
                            <Vertex pos="-3.25 0.25 0.25" />
                            <Vertex pos="-3.25 0.25 -15.75" />
                            <Vertex pos="-3.25 -0.25 0.25" />
                            <Vertex pos="-3.25 -0.25 -15.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 2.75" album="" material="bm_edge_white" texgens="0 1 0 3136 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3.25" album="" material="bm_edge_white" texgens="0 -1 0 -3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 960 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -832 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -832 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -15.75" album="" material="bm_edge_white" texgens="-1 0 0 960 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="210" owner="0" type="0" pos="20.25 23 -5.25" rot="1 0 0 0" scale="" transform="1 0 0 20.25 0 1 0 23 0 0 1 -5.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1 0.25" />
                            <Vertex pos="0.25 1 -0.25" />
                            <Vertex pos="0.25 -5 0.25" />
                            <Vertex pos="0.25 -5 -0.25" />
                            <Vertex pos="-0.25 1 0.25" />
                            <Vertex pos="-0.25 1 -0.25" />
                            <Vertex pos="-0.25 -5 0.25" />
                            <Vertex pos="-0.25 -5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1792 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 -1 0 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 -1 0 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="211" owner="0" type="0" pos="25.9829 -8.51764 -2" rot="1 0 0 0" scale="" transform="1 0 0 25.9829 0 1 0 -8.51764 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="23" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="1.98289 -0.00446987 1" />
                            <Vertex pos="1.88081 -0.517635 1" />
                            <Vertex pos="-1.98289 0.517635 1" />
                            <Vertex pos="1.98289 -0.00446987 -15" />
                            <Vertex pos="1.88081 -0.517635 -15" />
                            <Vertex pos="-1.98289 0.517635 -15" />
                        </Vertices>
                        <Face id="17" plane="0 0 1 -1" album="" material="bm_friction_bounce_low" texgens="1 0 0 -4.37988 0 -1 0 1156.51 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="18" plane="0 0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 -509.81 0 -1 0 578.257 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="19" plane="0.980784 -0.195095 0 -1.94566" album="" material="bm_grid_blank4" texgens="0.258819 0.965926 0 129.633 0 0 -1 128 0 0.258819 0.25" texRot="0" texScale="0.258819 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="20" plane="0.130526 0.991445 -0 -0.254388" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.991445 -0.130526 0 65.0718 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="21" plane="-0.258818 -0.965926 -0 -0.0132095" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.991445 -0.130526 0 65.0718 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="212" owner="0" type="0" pos="25.9319 -8.76537 -2" rot="1 0 0 0" scale="" transform="1 0 0 25.9319 0 1 0 -8.76537 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="23" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="1.93185 -0.269906 1" />
                            <Vertex pos="1.76367 -0.765367 1" />
                            <Vertex pos="-1.93185 0.765367 1" />
                            <Vertex pos="1.93185 -0.269906 -15" />
                            <Vertex pos="1.76367 -0.765367 -15" />
                            <Vertex pos="-1.93185 0.765367 -15" />
                        </Vertices>
                        <Face id="17" plane="0 0 1 -1" album="" material="bm_friction_bounce_low" texgens="1 0 0 -17.4463 0 -1 0 1219.93 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="18" plane="0 0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 -503.277 0 -1 0 609.967 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="19" plane="0.946934 -0.32143 0 -1.91609" album="" material="bm_grid_blank4" texgens="0.258819 0.965926 0 98.4149 0 0 -1 128 0 0.258819 0.25" texRot="0" texScale="0.258819 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="20" plane="0.258818 0.965926 -0 -0.239289" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.965926 -0.258818 0 66.0518 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="21" plane="-0.382683 -0.92388 -0 -0.0321798" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.965926 -0.258818 0 66.0518 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="213" owner="0" type="0" pos="25.8478 -9 -2" rot="1 0 0 0" scale="" transform="1 0 0 25.8478 0 1 0 -9 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="23" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="1.84776 -0.530729 1" />
                            <Vertex pos="1.61634 -1 1" />
                            <Vertex pos="-1.84776 1 1" />
                            <Vertex pos="1.84776 -0.530729 -15" />
                            <Vertex pos="1.61634 -1 -15" />
                            <Vertex pos="-1.84776 1 -15" />
                        </Vertices>
                        <Face id="17" plane="0 0 1 -1" album="" material="bm_friction_bounce_low" texgens="1 0 0 -38.9736 0 -1 0 1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="18" plane="0 0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 -492.513 0 -1 0 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="19" plane="0.896873 -0.442288 0 -1.89194" album="" material="bm_grid_blank4" texgens="0.258819 0.965926 0 67.7026 0 0 -1 128 0 0.258819 0.25" texRot="0" texScale="0.258819 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="20" plane="0.382683 0.92388 -0 -0.216775" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.92388 -0.382683 0 66.8734 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="21" plane="-0.500001 -0.866025 -0 -0.0578548" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.92388 -0.382683 0 66.8734 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="214" owner="0" type="0" pos="25.7321 -9.21752 -2" rot="1 0 0 0" scale="" transform="1 0 0 25.7321 0 1 0 -9.21752 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="23" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="1.73205 -0.782479 1" />
                            <Vertex pos="1.44136 -1.21752 1" />
                            <Vertex pos="-1.73205 1.21752 1" />
                            <Vertex pos="1.73205 -0.782479 -15" />
                            <Vertex pos="1.44136 -1.21752 -15" />
                            <Vertex pos="-1.73205 1.21752 -15" />
                        </Vertices>
                        <Face id="17" plane="0 0 1 -1" album="" material="bm_friction_bounce_low" texgens="1 0 0 -68.5947 0 -1 0 1335.69 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="18" plane="0 0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 -477.703 0 -1 0 667.843 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="19" plane="0.831464 -0.555579 0 -1.87486" album="" material="bm_grid_blank4" texgens="0.707106 0.707108 0 172.984 0 0 -1 128 0 0.25882 0.25" texRot="0" texScale="0.25882 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="20" plane="0.5 0.866025 -0 -0.188378" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.866025 -0.5 0 67.4804 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="21" plane="-0.608761 -0.793354 -0 -0.0884792" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.866025 -0.5 0 67.4804 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="215" owner="0" type="0" pos="25.5867 -9.41422 -2" rot="1 0 0 0" scale="" transform="1 0 0 25.5867 0 1 0 -9.41422 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="23" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="1.58671 -1.02082 1" />
                            <Vertex pos="1.24173 -1.41422 1" />
                            <Vertex pos="-1.58671 1.41422 1" />
                            <Vertex pos="1.58671 -1.02082 -15" />
                            <Vertex pos="1.24173 -1.41422 -15" />
                            <Vertex pos="-1.58671 1.41422 -15" />
                        </Vertices>
                        <Face id="17" plane="0 0 1 -1" album="" material="bm_friction_bounce_low" texgens="1 0 0 -105.805 0 -1 0 1386.04 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="18" plane="0 0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 -459.098 0 -1 0 693.02 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="19" plane="0.751858 -0.659326 0 -1.86603" album="" material="bm_grid_blank4" texgens="0.707106 0.707108 0 143.081 0 0 -1 128 0 0.25882 0.25" texRot="0" texScale="0.25882 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="20" plane="0.608761 0.793354 -0 -0.156049" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.793354 -0.608761 0 67.8315 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="21" plane="-0.707106 -0.707107 -0 -0.121968" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.793354 -0.608761 0 67.8315 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="216" owner="0" type="0" pos="25.4142 -9.5867 -2" rot="1 0 0 0" scale="" transform="1 0 0 25.4142 0 1 0 -9.5867 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="23" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="1.41422 -1.24173 1" />
                            <Vertex pos="1.02084 -1.58671 1" />
                            <Vertex pos="-1.41422 1.58671 1" />
                            <Vertex pos="1.41422 -1.24173 -15" />
                            <Vertex pos="1.02084 -1.58671 -15" />
                            <Vertex pos="-1.41422 1.58671 -15" />
                        </Vertices>
                        <Face id="17" plane="0 0 1 -1" album="" material="bm_friction_bounce_low" texgens="1 0 0 -149.962 0 -1 0 1430.19 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="18" plane="0 0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 -437.019 0 -1 0 715.097 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="19" plane="0.659341 -0.751844 0 -1.86604" album="" material="bm_grid_blank4" texgens="0.707106 0.707108 0 112.921 0 0 -1 128 0 0.25882 0.25" texRot="0" texScale="0.25882 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="20" plane="0.707107 0.707106 -0 -0.121968" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.707107 -0.707107 0 67.9028 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="21" plane="-0.793353 -0.608762 -0 -0.156046" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.707107 -0.707107 0 67.9028 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="217" owner="0" type="0" pos="25.2175 -9.73207 -2" rot="1 0 0 0" scale="" transform="1 0 0 25.2175 0 1 0 -9.73207 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="23" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="1.21751 -1.44134 1" />
                            <Vertex pos="0.782459 -1.73204 1" />
                            <Vertex pos="-1.21751 1.73204 1" />
                            <Vertex pos="1.21751 -1.44134 -15" />
                            <Vertex pos="0.782459 -1.73204 -15" />
                            <Vertex pos="-1.21751 1.73204 -15" />
                        </Vertices>
                        <Face id="17" plane="0 0 1 -1" album="" material="bm_friction_bounce_low" texgens="1 0 0 -200.312 0 -1 0 1467.41 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="18" plane="0 0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 -411.844 0 -1 0 733.705 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="19" plane="0.555575 -0.831466 0 -1.87485" album="" material="bm_grid_blank4" texgens="0.707106 0.707108 0 83.0176 0 0 -1 128 0 0.25882 0.25" texRot="0" texScale="0.25882 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="20" plane="0.793353 0.608762 -0 -0.088483" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.608763 -0.793352 0 67.6906 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="21" plane="-0.866027 -0.499997 -0 -0.188385" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.608763 -0.793352 0 67.6906 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="218" owner="0" type="0" pos="25 -9.84776 -2" rot="1 0 0 0" scale="" transform="1 0 0 25 0 1 0 -9.84776 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="23" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="0.999998 -1.61635 1" />
                            <Vertex pos="0.530729 -1.84777 1" />
                            <Vertex pos="-0.999996 1.84777 1" />
                            <Vertex pos="0.999998 -1.61635 -15" />
                            <Vertex pos="0.530729 -1.84777 -15" />
                            <Vertex pos="-0.999996 1.84777 -15" />
                        </Vertices>
                        <Face id="17" plane="0 0 1 -1" album="" material="bm_friction_bounce_low" texgens="1 0 0 -256.001 0 -1 0 1497.03 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="18" plane="0 0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 -384 0 -1 0 748.513 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="19" plane="0.44228 -0.896877 0 -1.89195" album="" material="bm_grid_blank4" texgens="0.965927 0.258815 0 188.297 0 0 -1 128 0 0.25882 0.25" texRot="0" texScale="0.25882 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="20" plane="0.866027 0.499997 -0 -0.0578536" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.499997 -0.866027 0 67.2065 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="21" plane="-0.923881 -0.38268 -0 -0.216773" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.499997 -0.866027 0 67.2065 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="219" owner="0" type="0" pos="24.7654 -9.93185 -2" rot="1 0 0 0" scale="" transform="1 0 0 24.7654 0 1 0 -9.93185 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="23" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="0.765368 -1.76367 1" />
                            <Vertex pos="0.269905 -1.93186 1" />
                            <Vertex pos="-0.765366 1.93186 1" />
                            <Vertex pos="0.765368 -1.76367 -15" />
                            <Vertex pos="0.269905 -1.93186 -15" />
                            <Vertex pos="-0.765366 1.93186 -15" />
                        </Vertices>
                        <Face id="17" plane="0 0 1 -1" album="" material="bm_friction_bounce_low" texgens="1 0 0 -316.069 0 -1 0 1518.55 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="18" plane="0 0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 -353.965 0 -1 0 759.277 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="19" plane="0.321448 -0.946927 0 -1.91609" album="" material="bm_grid_blank4" texgens="0.965927 0.258815 0 157.584 0 0 -1 128 0 0.25882 0.25" texRot="0" texScale="0.25882 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="20" plane="0.92388 0.382682 -0 -0.0321828" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.38268 -0.923881 0 66.486 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="21" plane="-0.965927 -0.258816 -0 -0.239289" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.38268 -0.923881 0 66.486 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="220" owner="0" type="0" pos="24.5176 -9.9829 -2" rot="1 0 0 0" scale="" transform="1 0 0 24.5176 0 1 0 -9.9829 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="23" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="0.517626 -1.88081 1" />
                            <Vertex pos="0.00445938 -1.98288 1" />
                            <Vertex pos="-0.517626 1.98288 1" />
                            <Vertex pos="0.517626 -1.88081 -15" />
                            <Vertex pos="0.00445938 -1.98288 -15" />
                            <Vertex pos="-0.517626 1.98288 -15" />
                        </Vertices>
                        <Face id="17" plane="0 0 1 -1" album="" material="bm_friction_bounce_low" texgens="1 0 0 -379.485 0 -1 0 1531.62 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="18" plane="0 0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 -322.257 0 -1 0 765.811 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="19" plane="0.195082 -0.980787 0 -1.94565" album="" material="bm_grid_blank4" texgens="0.965927 0.258815 0 126.367 0 0 -1 128 0 0.25882 0.25" texRot="0" texScale="0.25882 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="20" plane="0.965927 0.258814 -0 -0.0132087" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.258815 -0.965927 0 65.5778 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="21" plane="-0.991445 -0.130522 -0 -0.254388" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.258815 -0.965927 0 65.5778 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="221" owner="0" type="0" pos="24.261 -9.99998 -2" rot="1 0 0 0" scale="" transform="1 0 0 24.261 0 1 0 -9.99998 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="23" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="0.261057 -1.9658 1" />
                            <Vertex pos="-0.261055 -2.00002 1" />
                            <Vertex pos="-0.26104 2.00002 1" />
                            <Vertex pos="0.261057 -1.9658 -15" />
                            <Vertex pos="-0.261055 -2.00002 -15" />
                            <Vertex pos="-0.26104 2.00002 -15" />
                        </Vertices>
                        <Face id="17" plane="0 0 1 -1" album="" material="bm_friction_bounce_low" texgens="1 0 0 -445.175 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="18" plane="0 0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 -289.413 0 -1 0 767.998 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="19" plane="0.0654025 -0.997859 0 -1.97866" album="" material="bm_grid_blank4" texgens="0.965927 0.258815 0 95.1758 0 0 -1 128 0 0.25882 0.25" texRot="0" texScale="0.25882 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="20" plane="0.991445 0.130523 -0 -0.00224179" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.130523 -0.991445 0 64.5423 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="21" plane="-1 3.81466e-006 0 -0.261047" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.130523 -0.991445 0 64.5423 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="222" owner="0" type="0" pos="23.7389 -10 -2" rot="1 0 0 0" scale="" transform="1 0 0 23.7389 0 1 0 -10 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="23" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="0.261044 -1.99999 1" />
                            <Vertex pos="-0.261059 -1.96577 1" />
                            <Vertex pos="0.261059 1.99999 1" />
                            <Vertex pos="0.261044 -1.99999 -15" />
                            <Vertex pos="-0.261059 -1.96577 -15" />
                            <Vertex pos="0.261059 1.99999 -15" />
                        </Vertices>
                        <Face id="17" plane="0 -0 1 -1" album="" material="bm_friction_bounce_low" texgens="1 0 0 -578.831 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="18" plane="0 0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 -222.584 0 -1 0 768.001 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="19" plane="-0.0654019 -0.997859 -0 -1.97864" album="" material="bm_grid_blank4" texgens="0.965925 -0.258823 0 160.825 0 0 -1 128 0 0.25882 0.25" texRot="0" texScale="0.25882 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="20" plane="1 -3.81471e-006 0 -0.261051" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0 -1 0 64.0002 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="21" plane="-0.991444 0.13053 0 -0.00223336" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0 -1 0 64.0002 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="223" owner="0" type="0" pos="23.4824 -9.98289 -2" rot="1 0 0 0" scale="" transform="1 0 0 23.4824 0 1 0 -9.98289 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="23" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="-0.00447464 -1.98289 1" />
                            <Vertex pos="-0.517645 -1.88081 1" />
                            <Vertex pos="0.517645 1.98289 1" />
                            <Vertex pos="-0.00447464 -1.98289 -15" />
                            <Vertex pos="-0.517645 -1.88081 -15" />
                            <Vertex pos="0.517645 1.98289 -15" />
                        </Vertices>
                        <Face id="17" plane="0 -0 1 -1" album="" material="bm_friction_bounce_low" texgens="1 0 0 -644.517 0 -1 0 1531.62 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="18" plane="0 0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 -189.742 0 -1 0 765.81 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="19" plane="-0.195098 -0.980784 -0 -1.94566" album="" material="bm_grid_blank4" texgens="0.965925 -0.258823 0 129.635 0 0 -1 128 0 0.25882 0.25" texRot="0" texScale="0.25882 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="20" plane="0.991444 -0.13053 0 -0.25439" album="" material="bm_grid_blank4" texgens="0 0 -1 32 -0.13053 -0.991444 0 65.0719 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="21" plane="-0.965925 0.258823 0 -0.0132104" album="" material="bm_grid_blank4" texgens="0 0 -1 32 -0.13053 -0.991444 0 65.0719 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="224" owner="0" type="0" pos="23.2346 -9.93185 -2" rot="1 0 0 0" scale="" transform="1 0 0 23.2346 0 1 0 -9.93185 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="23" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="-0.269915 -1.93186 1" />
                            <Vertex pos="-0.765377 -1.76367 1" />
                            <Vertex pos="0.765377 1.93186 1" />
                            <Vertex pos="-0.269915 -1.93186 -15" />
                            <Vertex pos="-0.765377 -1.76367 -15" />
                            <Vertex pos="0.765377 1.93186 -15" />
                        </Vertices>
                        <Face id="17" plane="0 -0 1 -1" album="" material="bm_friction_bounce_low" texgens="1 0 0 -707.936 0 -1 0 1518.55 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="18" plane="0 0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 -158.032 0 -1 0 759.276 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="19" plane="-0.321447 -0.946928 -0 -1.91609" album="" material="bm_grid_blank4" texgens="0.965925 -0.258823 0 98.4158 0 0 -1 128 0 0.25882 0.25" texRot="0" texScale="0.25882 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="20" plane="0.965925 -0.258822 0 -0.23929" album="" material="bm_grid_blank4" texgens="0 0 -1 32 -0.258823 -0.965925 0 66.0516 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="21" plane="-0.923878 0.382688 0 -0.0321822" album="" material="bm_grid_blank4" texgens="0 0 -1 32 -0.258823 -0.965925 0 66.0516 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="225" owner="0" type="0" pos="23 -9.84774 -2" rot="1 0 0 0" scale="" transform="1 0 0 23 0 1 0 -9.84774 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="23" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="-0.530741 -1.84777 1" />
                            <Vertex pos="-1.00002 -1.61635 1" />
                            <Vertex pos="1.00002 1.84777 1" />
                            <Vertex pos="-0.530741 -1.84777 -15" />
                            <Vertex pos="-1.00002 -1.61635 -15" />
                            <Vertex pos="1.00002 1.84777 -15" />
                        </Vertices>
                        <Face id="17" plane="0 -0 1 -1" album="" material="bm_friction_bounce_low" texgens="1 0 0 -768.002 0 -1 0 1497.02 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="18" plane="0 0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 -127.999 0 -1 0 748.511 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="19" plane="-0.44229 -0.896872 -0 -1.89195" album="" material="bm_grid_blank4" texgens="0.965925 -0.258823 0 67.7034 0 0 -1 128 0 0.25882 0.25" texRot="0" texScale="0.25882 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="20" plane="0.923878 -0.382687 0 -0.216776" album="" material="bm_grid_blank4" texgens="0 0 -1 32 -0.382688 -0.923878 0 66.8729 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="21" plane="-0.866023 0.500004 0 -0.0578561" album="" material="bm_grid_blank4" texgens="0 0 -1 32 -0.382688 -0.923878 0 66.8729 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="226" owner="0" type="0" pos="22.7825 -9.73204 -2" rot="1 0 0 0" scale="" transform="1 0 0 22.7825 0 1 0 -9.73204 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="23" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="-0.782507 -1.73205 1" />
                            <Vertex pos="-1.21752 -1.44138 1" />
                            <Vertex pos="1.21752 1.73205 1" />
                            <Vertex pos="-0.782507 -1.73205 -15" />
                            <Vertex pos="-1.21752 -1.44138 -15" />
                            <Vertex pos="1.21752 1.73205 -15" />
                        </Vertices>
                        <Face id="17" plane="0 -0 1 -1" album="" material="bm_friction_bounce_low" texgens="1 0 0 -823.684 0 -1 0 1467.4 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="18" plane="0 0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 -100.158 0 -1 0 733.701 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="19" plane="-0.555577 -0.831465 -0 -1.87488" album="" material="bm_grid_blank4" texgens="0.707107 -0.707106 0 172.984 0 0 -1 128 0 0.258814 0.25" texRot="0" texScale="0.258814 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="20" plane="0.866022 -0.500006 0 -0.188365" album="" material="bm_grid_blank4" texgens="0 0 -1 32 -0.500005 -0.866023 0 67.48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="21" plane="-0.793355 0.608759 0 -0.0884739" album="" material="bm_grid_blank4" texgens="0 0 -1 32 -0.500005 -0.866023 0 67.48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="227" owner="0" type="0" pos="22.5858 -9.58673 -2" rot="1 0 0 0" scale="" transform="1 0 0 22.5858 0 1 0 -9.58673 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="23" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="-1.02082 -1.58669 1" />
                            <Vertex pos="-1.41419 -1.24172 1" />
                            <Vertex pos="1.41419 1.58669 1" />
                            <Vertex pos="-1.02082 -1.58669 -15" />
                            <Vertex pos="-1.41419 -1.24172 -15" />
                            <Vertex pos="1.41419 1.58669 -15" />
                        </Vertices>
                        <Face id="17" plane="0 -0 1 -1" album="" material="bm_friction_bounce_low" texgens="1 0 0 -874.04 0 -1 0 1430.2 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="18" plane="0 0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 -74.98 0 -1 0 715.101 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="19" plane="-0.65934 -0.751845 -0 -1.86601" album="" material="bm_grid_blank4" texgens="0.707107 -0.707106 0 143.083 0 0 -1 128 0 0.258814 0.25" texRot="0" texScale="0.258814 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="20" plane="0.793354 -0.60876 0 -0.156043" album="" material="bm_grid_blank4" texgens="0 0 -1 32 -0.608758 -0.793356 0 67.8321 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="21" plane="-0.707109 0.707105 0 -0.121967" album="" material="bm_grid_blank4" texgens="0 0 -1 32 -0.608758 -0.793356 0 67.8321 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="228" owner="0" type="0" pos="22.4133 -9.41421 -2" rot="1 0 0 0" scale="" transform="1 0 0 22.4133 0 1 0 -9.41421 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="23" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="-1.24173 -1.41423 1" />
                            <Vertex pos="-1.58672 -1.02085 1" />
                            <Vertex pos="1.58672 1.41423 1" />
                            <Vertex pos="-1.24173 -1.41423 -15" />
                            <Vertex pos="-1.58672 -1.02085 -15" />
                            <Vertex pos="1.58672 1.41423 -15" />
                        </Vertices>
                        <Face id="17" plane="0 -0 1 -1" album="" material="bm_friction_bounce_low" texgens="1 0 0 -918.19 0 -1 0 1386.04 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="18" plane="0 0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 -52.9048 0 -1 0 693.019 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="19" plane="-0.751837 -0.659349 -0 -1.86605" album="" material="bm_grid_blank4" texgens="0.707107 -0.707106 0 112.921 0 0 -1 128 0 0.258814 0.25" texRot="0" texScale="0.258814 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="20" plane="0.707109 -0.707104 0 -0.121974" album="" material="bm_grid_blank4" texgens="0 0 -1 32 -0.707103 -0.707111 0 67.9024 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="21" plane="-0.608764 0.793351 0 -0.156045" album="" material="bm_grid_blank4" texgens="0 0 -1 32 -0.707103 -0.707111 0 67.9024 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="229" owner="0" type="0" pos="22.2679 -9.21754 -2" rot="1 0 0 0" scale="" transform="1 0 0 22.2679 0 1 0 -9.21754 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="23" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="-1.44134 -1.21752 1" />
                            <Vertex pos="-1.73203 -0.782473 1" />
                            <Vertex pos="1.73203 1.21752 1" />
                            <Vertex pos="-1.44134 -1.21752 -15" />
                            <Vertex pos="-1.73203 -0.782473 -15" />
                            <Vertex pos="1.73203 1.21752 -15" />
                        </Vertices>
                        <Face id="17" plane="0 -0 1 -1" album="" material="bm_friction_bounce_low" texgens="1 0 0 -955.407 0 -1 0 1335.69 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="18" plane="0 0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 -34.2964 0 -1 0 667.845 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="19" plane="-0.831471 -0.555569 -0 -1.87485" album="" material="bm_grid_blank4" texgens="0.707107 -0.707106 0 83.0176 0 0 -1 128 0 0.258814 0.25" texRot="0" texScale="0.258814 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="20" plane="0.608765 -0.793351 0 -0.0884808" album="" material="bm_grid_blank4" texgens="0 0 -1 32 -0.79335 -0.608765 0 67.6905 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="21" plane="-0.500003 0.866024 0 -0.18838" album="" material="bm_grid_blank4" texgens="0 0 -1 32 -0.79335 -0.608765 0 67.6905 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="230" owner="0" type="0" pos="22.1523 -9 -2" rot="1 0 0 0" scale="" transform="1 0 0 22.1523 0 1 0 -9 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="23" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="-1.61634 -1.00001 1" />
                            <Vertex pos="-1.84776 -0.530746 1" />
                            <Vertex pos="1.84777 1.00001 1" />
                            <Vertex pos="-1.61634 -1.00001 -15" />
                            <Vertex pos="-1.84776 -0.530746 -15" />
                            <Vertex pos="1.84777 1.00001 -15" />
                        </Vertices>
                        <Face id="17" plane="0 -0 1 -1" album="" material="bm_friction_bounce_low" texgens="1 0 0 -985.022 0 -1 0 1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="18" plane="0 0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 -19.4888 0 -1 0 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="19" plane="-0.896868 -0.442298 -0 -1.89195" album="" material="bm_grid_blank4" texgens="0.258825 -0.965925 0 188.298 0 0 -1 128 0 0.25882 0.25" texRot="0" texScale="0.25882 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="20" plane="0.500002 -0.866024 0 -0.0578557" album="" material="bm_grid_blank4" texgens="0 0 -1 32 -0.866024 -0.500003 0 67.2062 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="21" plane="-0.382687 0.923878 0 -0.21677" album="" material="bm_grid_blank4" texgens="0 0 -1 32 -0.866024 -0.500003 0 67.2062 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="231" owner="0" type="0" pos="22.0681 -8.76538 -2" rot="1 0 0 0" scale="" transform="1 0 0 22.0681 0 1 0 -8.76538 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="23" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="-1.76366 -0.76537 1" />
                            <Vertex pos="-1.93184 -0.269913 1" />
                            <Vertex pos="1.93184 0.76537 1" />
                            <Vertex pos="-1.76366 -0.76537 -15" />
                            <Vertex pos="-1.93184 -0.269913 -15" />
                            <Vertex pos="1.93184 0.76537 -15" />
                        </Vertices>
                        <Face id="17" plane="0 -0 1 -1" album="" material="bm_friction_bounce_low" texgens="1 0 0 -1006.55 0 -1 0 1219.94 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="18" plane="0 0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 -8.72314 0 -1 0 609.969 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="19" plane="-0.946928 -0.321444 -0 -1.91608" album="" material="bm_grid_blank4" texgens="0.258825 -0.965925 0 157.586 0 0 -1 128 0 0.25882 0.25" texRot="0" texScale="0.25882 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="20" plane="0.382687 -0.923878 0 -0.0321813" album="" material="bm_grid_blank4" texgens="0 0 -1 32 -0.923878 -0.382688 0 66.4862 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="21" plane="-0.258822 0.965925 0 -0.239288" album="" material="bm_grid_blank4" texgens="0 0 -1 32 -0.923878 -0.382688 0 66.4862 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="232" owner="0" type="0" pos="22.0171 -8.51765 -2" rot="1 0 0 0" scale="" transform="1 0 0 22.0171 0 1 0 -8.51765 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="23" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="-1.88081 -0.517645 1" />
                            <Vertex pos="-1.98289 -0.00447083 1" />
                            <Vertex pos="1.98289 0.517646 1" />
                            <Vertex pos="-1.88081 -0.517645 -15" />
                            <Vertex pos="-1.98289 -0.00447083 -15" />
                            <Vertex pos="1.98289 0.517646 -15" />
                        </Vertices>
                        <Face id="17" plane="0 -0 1 -1" album="" material="bm_friction_bounce_low" texgens="1 0 0 -1019.62 0 -1 0 1156.52 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="18" plane="0 0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 -2.19043 0 -1 0 578.259 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="19" plane="-0.980784 -0.195095 -0 -1.94566" album="" material="bm_grid_blank4" texgens="0.258825 -0.965925 0 126.368 0 0 -1 128 0 0.25882 0.25" texRot="0" texScale="0.25882 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="20" plane="0.258823 -0.965925 0 -0.0132098" album="" material="bm_grid_blank4" texgens="0 0 -1 32 -0.965925 -0.258823 0 65.5775 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="21" plane="-0.130529 0.991444 0 -0.254392" album="" material="bm_grid_blank4" texgens="0 0 -1 32 -0.965925 -0.258823 0 65.5775 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="233" owner="0" type="0" pos="22.0171 -7.48236 -2" rot="1 0 0 0" scale="" transform="1 0 0 22.0171 0 1 0 -7.48236 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="23" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="-1.98289 0.00446033 1" />
                            <Vertex pos="-1.88082 0.517634 1" />
                            <Vertex pos="1.98289 -0.517633 1" />
                            <Vertex pos="-1.98289 0.00446033 -15" />
                            <Vertex pos="-1.88082 0.517634 -15" />
                            <Vertex pos="1.98289 -0.517633 -15" />
                        </Vertices>
                        <Face id="17" plane="-0 0 1 -1" album="" material="bm_friction_bounce_low" texgens="1 0 0 -1019.62 0 -1 0 891.485 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="18" plane="0 -0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 -2.18994 0 -1 0 445.743 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="19" plane="-0.980788 0.195074 0 -1.94566" album="" material="bm_grid_blank4" texgens="-0.25882 -0.965926 0 129.632 0 0 -1 128 0 0.258819 0.25" texRot="0" texScale="0.258819 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="20" plane="-0.130524 -0.991445 0 -0.254391" album="" material="bm_grid_blank4" texgens="0 0 -1 32 -0.991445 0.130524 0 65.0717 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="21" plane="0.258817 0.965926 0 -0.0132087" album="" material="bm_grid_blank4" texgens="0 0 -1 32 -0.991445 0.130524 0 65.0717 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="234" owner="0" type="0" pos="22.0681 -7.23464 -2" rot="1 0 0 0" scale="" transform="1 0 0 22.0681 0 1 0 -7.23464 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="23" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="-1.93185 0.269904 1" />
                            <Vertex pos="-1.76366 0.765364 1" />
                            <Vertex pos="1.93185 -0.765364 1" />
                            <Vertex pos="-1.93185 0.269904 -15" />
                            <Vertex pos="-1.76366 0.765364 -15" />
                            <Vertex pos="1.93185 -0.765364 -15" />
                        </Vertices>
                        <Face id="17" plane="-0 0 1 -1" album="" material="bm_friction_bounce_low" texgens="1 0 0 -1006.56 0 -1 0 828.067 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="18" plane="0 -0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 -8.72217 0 -1 0 414.033 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="19" plane="-0.946929 0.321443 0 -1.91609" album="" material="bm_grid_blank4" texgens="-0.25882 -0.965926 0 98.4137 0 0 -1 128 0 0.258819 0.25" texRot="0" texScale="0.258819 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="20" plane="-0.258817 -0.965926 0 -0.239289" album="" material="bm_grid_blank4" texgens="0 0 -1 32 -0.965926 0.258817 0 66.0518 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="21" plane="0.382682 0.92388 0 -0.0321813" album="" material="bm_grid_blank4" texgens="0 0 -1 32 -0.965926 0.258817 0 66.0518 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="235" owner="0" type="0" pos="22.1522 -7.00001 -2" rot="1 0 0 0" scale="" transform="1 0 0 22.1522 0 1 0 -7.00001 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="23" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="-1.84776 0.530735 1" />
                            <Vertex pos="-1.61634 0.999994 1" />
                            <Vertex pos="1.84776 -0.999994 1" />
                            <Vertex pos="-1.84776 0.530735 -15" />
                            <Vertex pos="-1.61634 0.999994 -15" />
                            <Vertex pos="1.84776 -0.999994 -15" />
                        </Vertices>
                        <Face id="17" plane="-0 0 1 -1" album="" material="bm_friction_bounce_low" texgens="1 0 0 -985.026 0 -1 0 768.002 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="18" plane="0 -0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 -19.4868 0 -1 0 384.001 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="19" plane="-0.896867 0.4423 0 -1.89194" album="" material="bm_grid_blank4" texgens="-0.25882 -0.965926 0 67.7018 0 0 -1 128 0 0.258819 0.25" texRot="0" texScale="0.258819 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="20" plane="-0.382682 -0.92388 0 -0.21677" album="" material="bm_grid_blank4" texgens="0 0 -1 32 -0.92388 0.382683 0 66.8731 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="21" plane="0.499998 0.866026 0 -0.0578547" album="" material="bm_grid_blank4" texgens="0 0 -1 32 -0.92388 0.382683 0 66.8731 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="236" owner="0" type="0" pos="22.268 -6.78248 -2" rot="1 0 0 0" scale="" transform="1 0 0 22.268 0 1 0 -6.78248 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="23" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="-1.73206 0.782473 1" />
                            <Vertex pos="-1.44138 1.21752 1" />
                            <Vertex pos="1.73206 -1.21752 1" />
                            <Vertex pos="-1.73206 0.782473 -15" />
                            <Vertex pos="-1.44138 1.21752 -15" />
                            <Vertex pos="1.73206 -1.21752 -15" />
                        </Vertices>
                        <Face id="17" plane="-0 0 1 -1" album="" material="bm_friction_bounce_low" texgens="1 0 0 -955.403 0 -1 0 712.316 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="18" plane="0 -0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 -34.2983 0 -1 0 356.158 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="19" plane="-0.831479 0.555557 0 -1.87488" album="" material="bm_grid_blank4" texgens="-0.707104 -0.70711 0 172.983 0 0 -1 128 0 0.258819 0.25" texRot="0" texScale="0.258819 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="20" plane="-0.499998 -0.866027 0 -0.188383" album="" material="bm_grid_blank4" texgens="0 0 -1 32 -0.866026 0.499998 0 67.48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="21" plane="0.608759 0.793355 0 -0.0884776" album="" material="bm_grid_blank4" texgens="0 0 -1 32 -0.866026 0.499998 0 67.48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="237" owner="0" type="0" pos="22.4133 -6.58579 -2" rot="1 0 0 0" scale="" transform="1 0 0 22.4133 0 1 0 -6.58579 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="23" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="-1.58671 1.02083 1" />
                            <Vertex pos="-1.24172 1.41421 1" />
                            <Vertex pos="1.58671 -1.41421 1" />
                            <Vertex pos="-1.58671 1.02083 -15" />
                            <Vertex pos="-1.24172 1.41421 -15" />
                            <Vertex pos="1.58671 -1.41421 -15" />
                        </Vertices>
                        <Face id="17" plane="-0 0 1 -1" album="" material="bm_friction_bounce_low" texgens="1 0 0 -918.198 0 -1 0 661.962 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="18" plane="0 -0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 -52.9009 0 -1 0 330.981 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="19" plane="-0.751835 0.659351 0 -1.86603" album="" material="bm_grid_blank4" texgens="-0.707104 -0.70711 0 143.082 0 0 -1 128 0 0.258819 0.25" texRot="0" texScale="0.258819 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="20" plane="-0.60876 -0.793354 0 -0.156044" album="" material="bm_grid_blank4" texgens="0 0 -1 32 -0.793355 0.60876 0 67.8315 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="21" plane="0.707106 0.707108 0 -0.121973" album="" material="bm_grid_blank4" texgens="0 0 -1 32 -0.793355 0.60876 0 67.8315 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="238" owner="0" type="0" pos="22.5858 -6.41329 -2" rot="1 0 0 0" scale="" transform="1 0 0 22.5858 0 1 0 -6.41329 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="23" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="-1.41421 1.24171 1" />
                            <Vertex pos="-1.02083 1.5867 1" />
                            <Vertex pos="1.41421 -1.5867 1" />
                            <Vertex pos="-1.41421 1.24171 -15" />
                            <Vertex pos="-1.02083 1.5867 -15" />
                            <Vertex pos="1.41421 -1.5867 -15" />
                        </Vertices>
                        <Face id="17" plane="-0 0 1 -1" album="" material="bm_friction_bounce_low" texgens="1 0 0 -874.041 0 -1 0 617.802 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="18" plane="0 -0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 -74.9795 0 -1 0 308.901 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="19" plane="-0.659351 0.751836 0 -1.86602" album="" material="bm_grid_blank4" texgens="-0.707104 -0.70711 0 112.92 0 0 -1 128 0 0.258819 0.25" texRot="0" texScale="0.258819 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="20" plane="-0.707106 -0.707108 0 -0.121972" album="" material="bm_grid_blank4" texgens="0 0 -1 32 -0.707108 0.707106 0 67.9034 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="21" plane="0.793353 0.608762 0 -0.156044" album="" material="bm_grid_blank4" texgens="0 0 -1 32 -0.707108 0.707106 0 67.9034 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="239" owner="0" type="0" pos="22.7825 -6.26795 -2" rot="1 0 0 0" scale="" transform="1 0 0 22.7825 0 1 0 -6.26795 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="23" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="-1.21752 1.44136 1" />
                            <Vertex pos="-0.782471 1.73205 1" />
                            <Vertex pos="1.21752 -1.73205 1" />
                            <Vertex pos="-1.21752 1.44136 -15" />
                            <Vertex pos="-0.782471 1.73205 -15" />
                            <Vertex pos="1.21752 -1.73205 -15" />
                        </Vertices>
                        <Face id="17" plane="-0 0 1 -1" album="" material="bm_friction_bounce_low" texgens="1 0 0 -823.688 0 -1 0 580.595 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="18" plane="0 -0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 -100.156 0 -1 0 290.298 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="19" plane="-0.555564 0.831474 0 -1.87487" album="" material="bm_grid_blank4" texgens="-0.707104 -0.70711 0 83.0183 0 0 -1 128 0 0.258819 0.25" texRot="0" texScale="0.258819 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="20" plane="-0.793353 -0.608762 0 -0.0884803" album="" material="bm_grid_blank4" texgens="0 0 -1 32 -0.608763 0.793352 0 67.6899 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="21" plane="0.866026 0.499999 0 -0.188383" album="" material="bm_grid_blank4" texgens="0 0 -1 32 -0.608763 0.793352 0 67.6899 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="240" owner="0" type="0" pos="23 -6.15225 -2" rot="1 0 0 0" scale="" transform="1 0 0 23 0 1 0 -6.15225 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="23" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="-1 1.61634 1" />
                            <Vertex pos="-0.530733 1.84776 1" />
                            <Vertex pos="1 -1.84776 1" />
                            <Vertex pos="-1 1.61634 -15" />
                            <Vertex pos="-0.530733 1.84776 -15" />
                            <Vertex pos="1 -1.84776 -15" />
                        </Vertices>
                        <Face id="17" plane="-0 0 1 -1" album="" material="bm_friction_bounce_low" texgens="1 0 0 -767.999 0 -1 0 550.975 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="18" plane="0 -0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 275.488 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="19" plane="-0.442291 0.896872 0 -1.89195" album="" material="bm_grid_blank4" texgens="-0.965926 -0.258819 0 188.297 0 0 -1 128 0 0.25882 0.25" texRot="0" texScale="0.25882 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="20" plane="-0.866025 -0.500001 0 -0.057855" album="" material="bm_grid_blank4" texgens="0 0 -1 32 -0.5 0.866025 0 67.2064 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="21" plane="0.92388 0.382683 0 -0.216775" album="" material="bm_grid_blank4" texgens="0 0 -1 32 -0.5 0.866025 0 67.2064 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="241" owner="0" type="0" pos="23.2346 -6.06817 -2" rot="1 0 0 0" scale="" transform="1 0 0 23.2346 0 1 0 -6.06817 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="23" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="-0.765373 1.76369 1" />
                            <Vertex pos="-0.269907 1.93187 1" />
                            <Vertex pos="0.765371 -1.93187 1" />
                            <Vertex pos="-0.765373 1.76369 -15" />
                            <Vertex pos="-0.269907 1.93187 -15" />
                            <Vertex pos="0.765371 -1.93187 -15" />
                        </Vertices>
                        <Face id="17" plane="-0 0 1 -1" album="" material="bm_friction_bounce_low" texgens="1 0 0 -707.933 0 -1 0 529.451 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="18" plane="0 -0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 -158.034 0 -1 0 264.725 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="19" plane="-0.321428 0.946934 0 -1.91611" album="" material="bm_grid_blank4" texgens="-0.965926 -0.258819 0 157.585 0 0 -1 128 0 0.25882 0.25" texRot="0" texScale="0.25882 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="20" plane="-0.92388 -0.382683 0 -0.0321808" album="" material="bm_grid_blank4" texgens="0 0 -1 32 -0.382683 0.92388 0 66.4855 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="21" plane="0.965926 0.258818 0 -0.239291" album="" material="bm_grid_blank4" texgens="0 0 -1 32 -0.382683 0.92388 0 66.4855 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="242" owner="0" type="0" pos="23.4824 -6.01711 -2" rot="1 0 0 0" scale="" transform="1 0 0 23.4824 0 1 0 -6.01711 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="23" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="-0.517633 1.88081 1" />
                            <Vertex pos="-0.00446892 1.98289 1" />
                            <Vertex pos="0.517635 -1.98289 1" />
                            <Vertex pos="-0.517633 1.88081 -15" />
                            <Vertex pos="-0.00446892 1.98289 -15" />
                            <Vertex pos="0.517635 -1.98289 -15" />
                        </Vertices>
                        <Face id="17" plane="-0 0 1 -1" album="" material="bm_friction_bounce_low" texgens="1 0 0 -644.515 0 -1 0 516.38 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="18" plane="0 -0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 -189.743 0 -1 0 258.19 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="19" plane="-0.195101 0.980783 0 -1.94566" album="" material="bm_grid_blank4" texgens="-0.965926 -0.258819 0 126.366 0 0 -1 128 0 0.25882 0.25" texRot="0" texScale="0.25882 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="20" plane="-0.965926 -0.258818 0 -0.0132092" album="" material="bm_grid_blank4" texgens="0 0 -1 32 -0.258818 0.965926 0 65.5775 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="21" plane="0.991445 0.130526 0 -0.254388" album="" material="bm_grid_blank4" texgens="0 0 -1 32 -0.258818 0.965926 0 65.5775 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="243" owner="0" type="0" pos="23.739 -5.99999 -2" rot="1 0 0 0" scale="" transform="1 0 0 23.739 0 1 0 -5.99999 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="23" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="-0.261053 1.96577 1" />
                            <Vertex pos="0.261051 1.99999 1" />
                            <Vertex pos="0.261047 -1.99999 1" />
                            <Vertex pos="-0.261053 1.96577 -15" />
                            <Vertex pos="0.261051 1.99999 -15" />
                            <Vertex pos="0.261047 -1.99999 -15" />
                        </Vertices>
                        <Face id="17" plane="-0 0 1 -1" album="" material="bm_friction_bounce_low" texgens="1 0 0 -578.829 0 -1 0 511.997 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="18" plane="0 0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 -222.585 0 -1 0 255.999 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="19" plane="-0.0654025 0.997859 0 -1.97863" album="" material="bm_grid_blank4" texgens="-0.965926 -0.258819 0 95.1755 0 0 -1 128 0 0.25882 0.25" texRot="0" texScale="0.25882 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="20" plane="-0.991445 -0.130526 0 -0.00223616" album="" material="bm_grid_blank4" texgens="0 0 -1 32 -0.130525 0.991445 0 64.5432 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="21" plane="1 -9.5368e-007 0 -0.261049" album="" material="bm_grid_blank4" texgens="0 0 -1 32 -0.130525 0.991445 0 64.5432 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="244" owner="0" type="0" pos="24.2611 -6.00001 -2" rot="1 0 0 0" scale="" transform="1 0 0 24.2611 0 1 0 -6.00001 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="23" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="-0.261049 2.00001 1" />
                            <Vertex pos="0.261057 1.96579 1" />
                            <Vertex pos="-0.261055 -2.00001 1" />
                            <Vertex pos="-0.261049 2.00001 -15" />
                            <Vertex pos="0.261057 1.96579 -15" />
                            <Vertex pos="-0.261055 -2.00001 -15" />
                        </Vertices>
                        <Face id="17" plane="0 0 1 -1" album="" material="bm_friction_bounce_low" texgens="1 0 0 -445.171 0 -1 0 512.002 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="18" plane="-0 0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 -289.415 0 -1 0 256.001 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="19" plane="0.0654014 0.997859 0 -1.97865" album="" material="bm_grid_blank4" texgens="-0.965926 0.258819 0 160.824 0 0 -1 128 0 0.25882 0.25" texRot="0" texScale="0.25882 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="20" plane="-1 1.43051e-006 0 -0.261052" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0 1 0 63.9997 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="21" plane="0.991445 -0.130527 0 -0.00223428" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0 1 0 63.9997 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="245" owner="0" type="0" pos="24.5176 -6.0171 -2" rot="1 0 0 0" scale="" transform="1 0 0 24.5176 0 1 0 -6.0171 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="23" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="0.00447083 1.98288 1" />
                            <Vertex pos="0.517639 1.8808 1" />
                            <Vertex pos="-0.517639 -1.98288 1" />
                            <Vertex pos="0.00447083 1.98288 -15" />
                            <Vertex pos="0.517639 1.8808 -15" />
                            <Vertex pos="-0.517639 -1.98288 -15" />
                        </Vertices>
                        <Face id="17" plane="0 0 1 -1" album="" material="bm_friction_bounce_low" texgens="1 0 0 -379.484 0 -1 0 516.378 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="18" plane="-0 0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 -322.258 0 -1 0 258.189 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="19" plane="0.195098 0.980784 0 -1.94565" album="" material="bm_grid_blank4" texgens="-0.965926 0.258819 0 129.635 0 0 -1 128 0 0.25882 0.25" texRot="0" texScale="0.25882 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="20" plane="-0.991445 0.130528 0 -0.254389" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.130527 0.991445 0 65.072 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="21" plane="0.965925 -0.258821 0 -0.0132102" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.130527 0.991445 0 65.072 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="246" owner="0" type="0" pos="24.7654 -6.06816 -2" rot="1 0 0 0" scale="" transform="1 0 0 24.7654 0 1 0 -6.06816 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="23" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="0.269915 1.93186 1" />
                            <Vertex pos="0.765371 1.76367 1" />
                            <Vertex pos="-0.765371 -1.93186 1" />
                            <Vertex pos="0.269915 1.93186 -15" />
                            <Vertex pos="0.765371 1.76367 -15" />
                            <Vertex pos="-0.765371 -1.93186 -15" />
                        </Vertices>
                        <Face id="17" plane="0 0 1 -1" album="" material="bm_friction_bounce_low" texgens="1 0 0 -316.066 0 -1 0 529.448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="18" plane="-0 0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 -353.967 0 -1 0 264.724 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="19" plane="0.321447 0.946927 0 -1.91609" album="" material="bm_grid_blank4" texgens="-0.965926 0.258819 0 98.4158 0 0 -1 128 0 0.25882 0.25" texRot="0" texScale="0.25882 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="20" plane="-0.965925 0.258821 0 -0.239287" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.25882 0.965926 0 66.0515 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="21" plane="0.923879 -0.382685 0 -0.0321819" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.25882 0.965926 0 66.0515 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="247" owner="0" type="0" pos="25 -6.15225 -2" rot="1 0 0 0" scale="" transform="1 0 0 25 0 1 0 -6.15225 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="23" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="0.530739 1.84776 1" />
                            <Vertex pos="1.00001 1.61635 1" />
                            <Vertex pos="-1.00001 -1.84776 1" />
                            <Vertex pos="0.530739 1.84776 -15" />
                            <Vertex pos="1.00001 1.61635 -15" />
                            <Vertex pos="-1.00001 -1.84776 -15" />
                        </Vertices>
                        <Face id="17" plane="0 0 1 -1" album="" material="bm_friction_bounce_low" texgens="1 0 0 -255.999 0 -1 0 550.976 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="18" plane="-0 0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 -384 0 -1 0 275.488 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="19" plane="0.442276 0.896879 0 -1.89195" album="" material="bm_grid_blank4" texgens="-0.965926 0.258819 0 67.7034 0 0 -1 128 0 0.25882 0.25" texRot="0" texScale="0.25882 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="20" plane="-0.923878 0.382686 0 -0.216774" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.382686 0.923879 0 66.8731 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="21" plane="0.866024 -0.500002 0 -0.057853" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.382686 0.923879 0 66.8731 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="248" owner="0" type="0" pos="25.2175 -6.26794 -2" rot="1 0 0 0" scale="" transform="1 0 0 25.2175 0 1 0 -6.26794 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="23" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="0.782478 1.73204 1" />
                            <Vertex pos="1.21752 1.44135 1" />
                            <Vertex pos="-1.21752 -1.73204 1" />
                            <Vertex pos="0.782478 1.73204 -15" />
                            <Vertex pos="1.21752 1.44135 -15" />
                            <Vertex pos="-1.21752 -1.73204 -15" />
                        </Vertices>
                        <Face id="17" plane="0 0 1 -1" album="" material="bm_friction_bounce_low" texgens="1 0 0 -200.312 0 -1 0 580.593 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="18" plane="-0 0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 -411.844 0 -1 0 290.297 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="19" plane="0.555577 0.831465 0 -1.87486" album="" material="bm_grid_blank4" texgens="-0.707105 0.707109 0 172.983 0 0 -1 128 0 0.25882 0.25" texRot="0" texScale="0.25882 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="20" plane="-0.866025 0.500001 0 -0.188377" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.500002 0.866024 0 67.4808 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="21" plane="0.793353 -0.608762 0 -0.0884799" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.500002 0.866024 0 67.4808 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="249" owner="0" type="0" pos="25.4142 -6.4133 -2" rot="1 0 0 0" scale="" transform="1 0 0 25.4142 0 1 0 -6.4133 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="23" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="1.02084 1.58671 1" />
                            <Vertex pos="1.41422 1.24172 1" />
                            <Vertex pos="-1.41422 -1.58671 1" />
                            <Vertex pos="1.02084 1.58671 -15" />
                            <Vertex pos="1.41422 1.24172 -15" />
                            <Vertex pos="-1.41422 -1.58671 -15" />
                        </Vertices>
                        <Face id="17" plane="0 0 1 -1" album="" material="bm_friction_bounce_low" texgens="1 0 0 -149.963 0 -1 0 617.805 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="18" plane="-0 0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 -437.019 0 -1 0 308.902 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="19" plane="0.659351 0.751835 0 -1.86604" album="" material="bm_grid_blank4" texgens="-0.707105 0.707109 0 143.081 0 0 -1 128 0 0.25882 0.25" texRot="0" texScale="0.25882 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="20" plane="-0.793352 0.608763 0 -0.156045" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.608763 0.793352 0 67.8314 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="21" plane="0.707105 -0.707108 0 -0.121973" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.608763 0.793352 0 67.8314 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="250" owner="0" type="0" pos="25.5867 -6.58579 -2" rot="1 0 0 0" scale="" transform="1 0 0 25.5867 0 1 0 -6.58579 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="23" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="1.24172 1.41421 1" />
                            <Vertex pos="1.58671 1.02083 1" />
                            <Vertex pos="-1.58671 -1.41421 1" />
                            <Vertex pos="1.24172 1.41421 -15" />
                            <Vertex pos="1.58671 1.02083 -15" />
                            <Vertex pos="-1.58671 -1.41421 -15" />
                        </Vertices>
                        <Face id="17" plane="0 0 1 -1" album="" material="bm_friction_bounce_low" texgens="1 0 0 -105.802 0 -1 0 661.962 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="18" plane="-0 0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 -459.099 0 -1 0 330.981 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="19" plane="0.751835 0.659351 0 -1.86603" album="" material="bm_grid_blank4" texgens="-0.707105 0.707109 0 112.92 0 0 -1 128 0 0.25882 0.25" texRot="0" texScale="0.25882 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="20" plane="-0.707105 0.707108 0 -0.121971" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.707108 0.707106 0 67.9032 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="21" plane="0.608759 -0.793355 0 -0.156046" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.707108 0.707106 0 67.9032 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="251" owner="0" type="0" pos="25.7321 -6.78248 -2" rot="1 0 0 0" scale="" transform="1 0 0 25.7321 0 1 0 -6.78248 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="23" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="1.44137 1.21752 1" />
                            <Vertex pos="1.73206 0.782472 1" />
                            <Vertex pos="-1.73206 -1.21752 1" />
                            <Vertex pos="1.44137 1.21752 -15" />
                            <Vertex pos="1.73206 0.782472 -15" />
                            <Vertex pos="-1.73206 -1.21752 -15" />
                        </Vertices>
                        <Face id="17" plane="0 0 1 -1" album="" material="bm_friction_bounce_low" texgens="1 0 0 -68.5947 0 -1 0 712.316 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="18" plane="-0 0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 -477.703 0 -1 0 356.158 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="19" plane="0.83147 0.555569 0 -1.87487" album="" material="bm_grid_blank4" texgens="-0.707105 0.707109 0 83.0176 0 0 -1 128 0 0.25882 0.25" texRot="0" texScale="0.25882 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="20" plane="-0.608759 0.793355 0 -0.0884804" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.793355 0.60876 0 67.6898 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="21" plane="0.499997 -0.866027 0 -0.188383" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.793355 0.60876 0 67.6898 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="252" owner="0" type="0" pos="25.8478 -7 -2" rot="1 0 0 0" scale="" transform="1 0 0 25.8478 0 1 0 -7 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="23" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="1.61634 0.999991 1" />
                            <Vertex pos="1.84775 0.530723 1" />
                            <Vertex pos="-1.84775 -0.999991 1" />
                            <Vertex pos="1.61634 0.999991 -15" />
                            <Vertex pos="1.84775 0.530723 -15" />
                            <Vertex pos="-1.84775 -0.999991 -15" />
                        </Vertices>
                        <Face id="17" plane="0 0 1 -1" album="" material="bm_friction_bounce_low" texgens="1 0 0 -38.9717 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="18" plane="-0 0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 -492.514 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="19" plane="0.896879 0.442276 0 -1.89194" album="" material="bm_grid_blank4" texgens="-0.258815 0.965927 0 188.297 0 0 -1 128 0 0.258818 0.25" texRot="0" texScale="0.258818 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="20" plane="-0.499997 0.866027 0 -0.057852" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.866027 0.499997 0 67.2069 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="21" plane="0.382681 -0.923881 0 -0.216774" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.866027 0.499997 0 67.2069 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="253" owner="0" type="0" pos="25.9319 -7.23464 -2" rot="1 0 0 0" scale="" transform="1 0 0 25.9319 0 1 0 -7.23464 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="23" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="1.76367 0.765362 1" />
                            <Vertex pos="1.93186 0.269902 1" />
                            <Vertex pos="-1.93186 -0.765362 1" />
                            <Vertex pos="1.76367 0.765362 -15" />
                            <Vertex pos="1.93186 0.269902 -15" />
                            <Vertex pos="-1.93186 -0.765362 -15" />
                        </Vertices>
                        <Face id="17" plane="0 0 1 -1" album="" material="bm_friction_bounce_low" texgens="1 0 0 -17.4463 0 -1 0 828.068 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="18" plane="-0 0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 -503.277 0 -1 0 414.034 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="19" plane="0.946928 0.321446 0 -1.91609" album="" material="bm_grid_blank4" texgens="-0.258815 0.965927 0 157.584 0 0 -1 128 0 0.258818 0.25" texRot="0" texScale="0.258818 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="20" plane="-0.38268 0.923881 0 -0.0321813" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.923881 0.38268 0 66.486 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="21" plane="0.258815 -0.965927 0 -0.239289" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.923881 0.38268 0 66.486 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="254" owner="0" type="0" pos="25.9829 -7.48237 -2" rot="1 0 0 0" scale="" transform="1 0 0 25.9829 0 1 0 -7.48237 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="23" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="1.88081 0.517628 1" />
                            <Vertex pos="1.98288 0.004457 1" />
                            <Vertex pos="-1.98289 -0.517629 1" />
                            <Vertex pos="1.88081 0.517628 -15" />
                            <Vertex pos="1.98288 0.004457 -15" />
                            <Vertex pos="-1.98289 -0.517629 -15" />
                        </Vertices>
                        <Face id="17" plane="0 0 1 -1" album="" material="bm_friction_bounce_low" texgens="1 0 0 -4.37988 0 -1 0 891.487 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="18" plane="-0 0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 -509.81 0 -1 0 445.743 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="19" plane="0.980788 0.195079 0 -1.94566" album="" material="bm_grid_blank4" texgens="-0.258815 0.965927 0 126.365 0 0 -1 128 0 0.258818 0.25" texRot="0" texScale="0.258818 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="20" plane="-0.258815 0.965927 0 -0.0132086" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.965927 0.258815 0 65.5777 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="21" plane="0.130522 -0.991446 0 -0.254391" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.965927 0.258815 0 65.5777 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="255" owner="0" type="0" pos="26 -8.26105 -2" rot="1 0 0 0" scale="" transform="1 0 0 26 0 1 0 -8.26105 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="13">
                        <Vertices>
                            <Vertex pos="2 0.261053 1" />
                            <Vertex pos="1.96578 -0.261053 1" />
                            <Vertex pos="-2 0.261053 1" />
                            <Vertex pos="2 0.261053 -15" />
                            <Vertex pos="1.96578 -0.261053 -15" />
                            <Vertex pos="-2 0.261053 -15" />
                        </Vertices>
                        <Face id="5" plane="0 0 1 -1" album="" material="bm_friction_bounce_low" texgens="1 0 0 -0.000976563 0 -1 0 1090.83 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="6" plane="0 0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 545.415 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="7" plane="0.997859 -0.065405 0 -1.97865" album="" material="bm_grid_blank4" texgens="0.258819 0.965926 0 160.824 0 0 -1 128 0 0.258819 0.25" texRot="0" texScale="0.258819 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="8" plane="0 1 -0 -0.261053" album="" material="bm_grid_blank4" texgens="0 0 -1 32 1 0 0 64 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="9" plane="-0.130526 -0.991445 -0 -0.00223356" album="" material="bm_grid_blank4" texgens="0 0 -1 32 1 0 0 64 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="256" owner="0" type="0" pos="22 -8.26106 -2" rot="1 0 0 0" scale="" transform="1 0 0 22 0 1 0 -8.26106 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="13">
                        <Vertices>
                            <Vertex pos="-1.96579 -0.261059 1" />
                            <Vertex pos="-2.00001 0.261049 1" />
                            <Vertex pos="2 0.261059 1" />
                            <Vertex pos="-1.96579 -0.261059 -15" />
                            <Vertex pos="-2.00001 0.261049 -15" />
                            <Vertex pos="2 0.261059 -15" />
                        </Vertices>
                        <Face id="5" plane="0 -0 1 -1" album="" material="bm_friction_bounce_low" texgens="1 0 0 -1024 0 -1 0 1090.83 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="6" plane="0 0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 -0.000488281 0 -1 0 545.416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="7" plane="-0.997859 -0.0654012 -0 -1.97865" album="" material="bm_grid_blank4" texgens="0.258825 -0.965925 0 95.1772 0 0 -1 128 0 0.25882 0.25" texRot="0" texScale="0.25882 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="8" plane="0.130529 -0.991444 0 -0.00223318" album="" material="bm_grid_blank4" texgens="0 0 -1 32 -0.991445 -0.130529 0 64.5426 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="9" plane="-2.38418e-006 1 0 -0.261054" album="" material="bm_grid_blank4" texgens="0 0 -1 32 -0.991445 -0.130529 0 64.5426 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="257" owner="0" type="0" pos="22 -7.73896 -2" rot="1 0 0 0" scale="" transform="1 0 0 22 0 1 0 -7.73896 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="13">
                        <Vertices>
                            <Vertex pos="-2 -0.261054 1" />
                            <Vertex pos="-1.96578 0.261054 1" />
                            <Vertex pos="2 -0.261043 1" />
                            <Vertex pos="-2 -0.261054 -15" />
                            <Vertex pos="-1.96578 0.261054 -15" />
                            <Vertex pos="2 -0.261043 -15" />
                        </Vertices>
                        <Face id="5" plane="0 0 1 -1" album="" material="bm_friction_bounce_low" texgens="1 0 0 -1024 0 -1 0 957.173 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="6" plane="0 -0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 478.586 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="7" plane="-0.997859 0.0654013 0 -1.97865" album="" material="bm_grid_blank4" texgens="-0.25882 -0.965926 0 160.823 0 0 -1 128 0 0.258819 0.25" texRot="0" texScale="0.258819 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="8" plane="2.6226e-006 -1 0 -0.261048" album="" material="bm_grid_blank4" texgens="0 0 -1 32 -1 0 0 63.9999 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="9" plane="0.130524 0.991445 0 -0.00223845" album="" material="bm_grid_blank4" texgens="0 0 -1 32 -1 0 0 63.9999 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="258" owner="0" type="0" pos="26 -7.73896 -2" rot="1 0 0 0" scale="" transform="1 0 0 26 0 1 0 -7.73896 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="13">
                        <Vertices>
                            <Vertex pos="1.96578 0.261044 1" />
                            <Vertex pos="2 -0.261045 1" />
                            <Vertex pos="-2 -0.261045 1" />
                            <Vertex pos="1.96578 0.261044 -15" />
                            <Vertex pos="2 -0.261045 -15" />
                            <Vertex pos="-2 -0.261045 -15" />
                        </Vertices>
                        <Face id="5" plane="0 0 1 -1" album="" material="bm_friction_bounce_low" texgens="1 0 0 0.000976563 0 -1 0 957.173 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="6" plane="0 0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 478.586 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="7" plane="0.997859 0.0654072 0 -1.97865" album="" material="bm_grid_blank4" texgens="-0.258815 0.965927 0 95.1749 0 0 -1 128 0 0.258818 0.25" texRot="0" texScale="0.258818 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="8" plane="-0.130522 0.991445 0 -0.00223312" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.991445 0.130522 0 64.5429 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="9" plane="0 -1 0 -0.261045" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.991445 0.130522 0 64.5429 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                </Brushes>
            </InteriorMap>
        </DetailLevel>
    </DetailLevels>
</ConstructorScene>
